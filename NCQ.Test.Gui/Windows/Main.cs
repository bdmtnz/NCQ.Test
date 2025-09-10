using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using NCQ.Test.Domain.Tasks.ValueObjects;
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

        private IDictionary<string, List<RelationalFk>> combos = new Dictionary<string, List<RelationalFk>>();

        public Main(IServiceProvider provider)
        {
            _mapper = provider.GetService<IMapper>();
            _term = provider.GetService<ITermService>();
            _task = provider.GetService<ITaskService>();

            InitializeComponent();
            Initialize();
        }

        private async void Initialize()
        {
            var stateTerm = await _term.GetWithChildren("STATES");
            if (stateTerm != null)
            {
                var states = stateTerm.Terms
                    .ToList()
                    .ConvertAll(_mapper.Map<RelationalFk>);
                combos.Add("STATES", states);
            }

            var priorityTerm = await _term.GetWithChildren("PRIORITIES");
            if (priorityTerm != null)
            {
                var priorities = priorityTerm.Terms
                    .ToList()
                    .ConvertAll(_mapper.Map<RelationalFk>);
                combos.Add("PRIORITIES", priorities);
            }
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            var modal = new AlterModal(combos);
            var result = modal.ShowDialog();
        }
    }
}
