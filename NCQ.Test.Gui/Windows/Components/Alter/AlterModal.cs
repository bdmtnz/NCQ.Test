using DevExpress.XtraGrid.Views.Card;
using FluentValidation.Results;
using Mapster;
using NCQ.Test.Domain.Tasks;
using NCQ.Test.Domain.Tasks.ValueObjects;
using NCQ.Test.Gui.Domain.Common.Contracts.Gui;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NCQ.Test.Gui.Windows.Components.Alter
{
    public partial class AlterModal : Form, IValueModal<Task>
    {
        public string[] RequiredCombos = new string[] { "STATUS", "PRIORITIES" };

        public AlterModal(IDictionary<string, List<RelationalFk>> combos)
        {
            InitializeComponent();
            InitializeBinding();
            Initialize(combos);
        }

        public AlterModal(IDictionary<string, List<RelationalFk>> combos, Task task)
        {
            InitializeComponent();
            InitializeBinding();
            Map(task);
            Initialize(combos);
        }

        private void InitializeBinding()
        {
            FormMvvm.SetViewModel(typeof(AlterModalViewModel), AlterModalViewModel.CreateDefault());

            FormMvvm.SetBinding(ModalTitle, c => c.Text, "Title");
            FormMvvm.SetBinding(CtrlDescription, c => c.Text, "Description");
        }

        private void Map(Task value)
        {
            if (value == null)
            {
                FormMvvm.SetViewModel(typeof(AlterModalViewModel), Task.Create(string.Empty, string.Empty));
            }

            FormMvvm.SetViewModel(typeof(AlterModalViewModel), value);
        }        

        private void Initialize(IDictionary<string, List<RelationalFk>> combos)
        {
            var stateDefault = combos["STATES"]
                .FirstOrDefault();
            CtrlState.Properties.DataSource = combos["STATES"];
            CtrlState.Properties.DisplayMember = "Text";
            CtrlState.Properties.ValueMember = "Id";
            CtrlState.EditValue = stateDefault.Id;

            CtrlPriority.Properties.DataSource = combos["PRIORITIES"];
            CtrlPriority.Properties.DisplayMember = "Text";
            CtrlPriority.Properties.ValueMember = "Id";
        }

        private void ApplyError(string ctrlName, string message)
        {
            var ctrl = this.Controls.Find(ctrlName, true).FirstOrDefault();
            if (ctrl != null)
            {
                FormError.SetError(ctrl, message, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
            }
        }

        private void WinAccept_Click(object sender, System.EventArgs e)
        {
            FormError.ClearErrors();

            var result = IsValid();
            if (result.IsValid)
            {
                Close();
                return;
            }
            
            for (int i = 0; i < result.Errors.Count; i++)
            {
                var error = result.Errors[i];
                var ctrlName = $"Ctrl{error.PropertyName}";
                var errorMessage = error.ErrorMessage;
                ApplyError(ctrlName, errorMessage);
            }
        }

        public Task GetValue()
        {
            var value = FormMvvm.GetViewModel<AlterModalViewModel>();
            return value.Adapt<Task>();
        }

        public ValidationResult IsValid()
        {
            var value = FormMvvm.GetViewModel<AlterModalViewModel>();
            var result = new AlterModalValidator().Validate(value);
            return result;
        }
    }
}
