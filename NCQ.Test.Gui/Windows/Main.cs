using DevExpress.XtraRichEdit.Import.Html;
using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using NCQ.Test.Gui.Domain.Common;
using NCQ.Test.Gui.Domain.Common.Contracts.Service;
using NCQ.Test.Gui.Windows.Components.Alter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NCQ.Test.Gui
{
    public partial class Main : Form
    {
        private readonly IMapper _mapper;
        private readonly ITermService _term;
        private readonly ITaskService _task;

        private IDictionary<string, List<ComboItem>> combos = new Dictionary<string, List<ComboItem>>();

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

            var tasks = await _task.Get();
            GridTasks.DataSource = tasks;
		}

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            var modal = new AlterModal(combos);
            var result = modal.ShowDialog();
            if (result == DialogResult.OK)
            {

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
    }
}
