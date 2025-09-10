using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using NCQ.Test.Gui.Domain.Common;
using NCQ.Test.Gui.Domain.Common.Contracts.Service;
using NCQ.Test.Gui.Windows.Components.Alter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCQ.Test.Gui
{
    public partial class Main : Form
    {
        private readonly IMapper _mapper;
        private readonly ITermService _term;
        private readonly ITaskService _task;

        private IDictionary<string, List<ComboItem>> combos = new Dictionary<string, List<ComboItem>>();
        private Test.Domain.Tasks.Task focused = default;

        public Main(IServiceProvider provider)
        {
            _mapper = provider.GetService<IMapper>();
            _term = provider.GetService<ITermService>();
            _task = provider.GetService<ITaskService>();

            InitializeComponent();
			FormBorderStyle = FormBorderStyle.FixedSingle;

			Initialize();
        }

        private void InitializeStatusRepository(List<ComboItem> items)
		{
			StatusRepository.DataSource = items;
            StatusRepository.DisplayMember = "Text";
            StatusRepository.ValueMember = "Id";
		}

		private void InitializePriorityRepository(List<ComboItem> items)
		{
			PriorityRepository.DataSource = items;
			PriorityRepository.DisplayMember = "Text";
			PriorityRepository.ValueMember = "Id";
		}

        private async Task LoadData()
		{
			var tasks = await _task.Get();
			GridTasks.DataSource = tasks;
		}

		private async void Initialize()
        {
            var stateTerm = await _term.GetWithChildren("STATES");
            if (stateTerm != null)
            {
                var states = stateTerm.Terms
                    .ToList()
                    .ConvertAll(_mapper.Map<ComboItem>);
                combos.Add("STATES", states);

				InitializeStatusRepository(states);
            }

            var priorityTerm = await _term.GetWithChildren("PRIORITIES");
            if (priorityTerm != null)
            {
                var priorities = priorityTerm.Terms
                    .ToList()
                    .ConvertAll(_mapper.Map<ComboItem>);
                combos.Add("PRIORITIES", priorities);

				InitializePriorityRepository(priorities);
			}

            await LoadData();
		}

        private async Task AlterTask(Test.Domain.Tasks.Task task)
        {
			var rowAffecteds = await _task.Add(task);
			if (rowAffecteds > 0)
			{
				await LoadData();
			}
		}

        private async void ButtonCreate_Click(object sender, EventArgs e)
        {
            var modal = new AlterModal(combos);
            var result = modal.ShowDialog();
            if (result == DialogResult.OK)
			{
				var value = modal.GetValue();
                await AlterTask(value);
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
                    focused = rowData as Test.Domain.Tasks.Task;

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
    }
}
