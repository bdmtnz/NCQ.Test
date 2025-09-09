using NCQ.Test.Domain.Tasks;
using System.Linq;
using System.Windows.Forms;

namespace NCQ.Test.Gui.Windows.Components
{
    public partial class AlterModal : Form
    {
        private Task SourceForm = Task.Create(string.Empty, string.Empty);

        public AlterModal()
        {
            InitializeComponent();
            Initialize();
        }

        public AlterModal(Task task)
        {
            InitializeComponent();
            Map(task);
            Initialize();
        }

        private void Map(Task value)
        {
            if (value == null)
            {
                SourceForm = Task.Create(string.Empty, string.Empty);
            }

            SourceForm = value;
        }

        private void Initialize()
        {
            var combo = this.Controls.Find("ComboState", true).FirstOrDefault();
            if (combo != null)
            {
                FormError.SetError(combo, "Error Test Message", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
            }
            FormError.SetError(CtrlDescription, "Error Test Message", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
            FormError.SetError(CtrlPriority, "Error Test Message", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
        }
    }
}
