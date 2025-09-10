using FluentValidation.Results;
using Mapster;
using NCQ.Test.Domain.Tasks;
using NCQ.Test.Gui.Domain.Common.Contracts.Gui;
using System.Linq;

namespace NCQ.Test.Gui.Windows.Components.Alter
{
    public partial class AlterModal : DevExpress.XtraEditors.XtraForm, IValueModal<Task>
    {
        public AlterModal()
        {
            InitializeComponent();
            InitializeBinding();
            Initialize();
        }

        public AlterModal(Task task)
        {
            InitializeComponent();
            InitializeBinding();
            Map(task);
            Initialize();
        }

        private void InitializeBinding()
        {
            FormMvvm.SetViewModel(typeof(AlterModalViewModel), AlterModalViewModel.CreateDefault());
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

        private void Initialize()
        {

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
