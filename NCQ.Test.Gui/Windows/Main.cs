using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using NCQ.Test.Domain.Terms;
using NCQ.Test.Gui.Domain.Common;
using NCQ.Test.Gui.Domain.Common.Contracts.Repositories.Tasks;
using NCQ.Test.Gui.Domain.Common.Contracts.Service;
using NCQ.Test.Gui.Windows;
using NCQ.Test.Gui.Windows.Components.Alter;
using NCQ.Test.Gui.Windows.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCQ.Test.Gui
{
    public partial class Main : Form
    {
        private MainViewModel _viewModel = MainViewModel.CreateDefault();
        private readonly IMapper _mapper;
        private readonly ITermService _term;
        private readonly ITaskService _task;
        private readonly MainContextMenuSettingFactory _contextConfigurator;

		private List<Term> states = new List<Term>();
		private List<Term> priorities = new List<Term>();
		private IDictionary<string, List<ComboItem>> combos = new Dictionary<string, List<ComboItem>>();
		private Test.Domain.Tasks.Task focused = default;

        public Main(IServiceProvider provider)
        {
            _mapper = provider.GetService<IMapper>();
            _term = provider.GetService<ITermService>();
            _task = provider.GetService<ITaskService>();
            _contextConfigurator = new MainContextMenuSettingFactory("ContextMenuBtn");

			InitializeComponent();

			Initialize();
            InitializeBinding();
        }
        private void InitializeBinding()
        {
            FormMvvm.SetViewModel(typeof(MainViewModel), _viewModel);

            FormMvvm.SetBinding(CtrlPriorityId, c => c.EditValue, "PriorityId");
            FormMvvm.SetBinding(CtrlStatusId, c => c.EditValue, "StatusId");
            FormMvvm.SetBinding(CtrlCommitmentStart, c => c.EditValue, "CommitmentStart");
            FormMvvm.SetBinding(CtrlCommitmentEnd, c => c.EditValue, "CommitmentEnd");
        }

        private void InitializeStatusCombos(List<ComboItem> items)
		{
			StatusRepository.DataSource = items;
            StatusRepository.DisplayMember = "Text";
            StatusRepository.ValueMember = "Id";

            CtrlStatusId.Properties.DataSource = items;
            CtrlStatusId.Properties.DisplayMember = "Text";
            CtrlStatusId.Properties.ValueMember = "Id";
        }

		private void InitializePriorityCombos(List<ComboItem> items)
		{
			PriorityRepository.DataSource = items;
			PriorityRepository.DisplayMember = "Text";
			PriorityRepository.ValueMember = "Id";

            CtrlPriorityId.Properties.DataSource = items;
            CtrlPriorityId.Properties.DisplayMember = "Text";
            CtrlPriorityId.Properties.ValueMember = "Id";
        }

        private async Task LoadData()
		{
            var dto = _viewModel.Adapt<TaskFilterDto>();
            var tasks = await _task.Filter(dto);
            GridTasks.DataSource = tasks;
        }

		private async void Initialize()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;

            var stateTerm = await _term.GetWithChildren("STATES");
            if (stateTerm != null)
            {
                var states = stateTerm.Terms
                    .ToList()
                    .ConvertAll(_mapper.Map<ComboItem>);
				combos.Add("STATES", states);
				this.states.AddRange(stateTerm.Terms);

				InitializeStatusCombos(states);
            }

            var priorityTerm = await _term.GetWithChildren("PRIORITIES");
            if (priorityTerm != null)
            {
                var priorities = priorityTerm.Terms
                    .ToList()
                    .ConvertAll(_mapper.Map<ComboItem>);
                combos.Add("PRIORITIES", priorities);
                this.priorities.AddRange(priorityTerm.Terms);

				InitializePriorityCombos(priorities);
			}

            await LoadData();
		}

        private async Task<int> AlterTask(Test.Domain.Tasks.Task task)
        {
            var rowAffecteds = 0;

            if (task.Id == default)
            {
                rowAffecteds = await _task.Add(task);
            }
            else
            {
                rowAffecteds = await _task.Update(task);
            }

            return rowAffecteds;
		}

        private async void ButtonCreate_Click(object sender, EventArgs e)
        {
            var modal = new AlterModal(combos);
            var result = modal.ShowDialog();
            if (result == DialogResult.OK)
			{
				var value = modal.GetValue();
                await AlterTask(value);

                CleanFilters();
                var tasks = await _task.Get();
                GridTasks.DataSource = tasks;
            }
        }

        private void HTProfile_Click(object sender, EventArgs e)
        {
			try
			{
				string url = "https://github.com/bdmtnz";
				System.Diagnostics.Process.Start(url);
			}
			catch { }
		}

        private void ContextMenuConfigurator(Test.Domain.Tasks.Task task)
		{
			var state = states.FirstOrDefault(t => t.Id == task.StatusId);
			if (state != null)
			{
				var setup = _contextConfigurator.Setup(state.Code);
				setup.Invoke(ContextMenuRow);
			}
        }

        private void GridTasks_MouseDown(object sender, MouseEventArgs e)
        {
			if (e.Button == MouseButtons.Right)
			{
				var view = GidViewTasks;
				if (view == null) return;

				DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInfo = view.CalcHitInfo(e.Location);

				if (hitInfo.InRow)
				{
					view.FocusedRowHandle = hitInfo.RowHandle;

					object rowData = view.GetRow(hitInfo.RowHandle);
                    var row = focused = rowData as Test.Domain.Tasks.Task;
					ContextMenuConfigurator(row);

					ContextMenuRow.Show(Cursor.Position);
				}
			}
		}

        private async void ContextMenuEditBtn_Click(object sender, EventArgs e)
        {
			var modal = new AlterModal(combos, focused);
			var result = modal.ShowDialog();
			if (result == DialogResult.OK)
			{
				var value = modal.GetValue();
				await AlterTask(value);

                await LoadData();
			}
		}

        private async void ContextMenuRemoveBtn_Click(object sender, EventArgs e)
        {
			var result = MessageBox.Show(
                "¿Está seguro de que desea eliminar este registro?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                await _task.Delete(focused);
                await LoadData();
            }
        }

        private async void BtnFilter_Click(object sender, EventArgs e) => await LoadData();

        private void CleanFilters()
        {
            _viewModel = MainViewModel.CreateDefault();
            InitializeBinding();
        }

        private void BtnClean_Click(object sender, EventArgs e) => CleanFilters();
    }
}
