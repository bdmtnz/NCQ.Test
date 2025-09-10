using Microsoft.Extensions.DependencyInjection;
using NCQ.Test.Gui.Domain.Common.Contracts.Service;
using System;
using System.Windows.Forms;

namespace NCQ.Test.Gui
{
    public partial class Main : Form
    {
        private readonly ITermService _term;
        private readonly ITaskService _task;

        public Main(IServiceProvider provider)
        {
            _term = provider.GetService<ITermService>();
            _task = provider.GetService<ITaskService>();

            InitializeComponent();
        }

        private void Initialize()
        {
        }
    }
}
