using FluentValidation.Results;
using Mapster;
using NCQ.Test.Domain.Tasks;
using NCQ.Test.Gui.Domain.Common;
using NCQ.Test.Gui.Domain.Common.Contracts.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NCQ.Test.Gui.Windows.Components.Alter
{
    public partial class AlterModal : Form, IValueModal<Task>
    {
        private readonly AlterModalViewModel _viewModel = AlterModalViewModel.CreateDefault();
        public string[] RequiredCombos = new string[] { "STATUS", "PRIORITIES" };

        public AlterModal(IDictionary<string, List<ComboItem>> combos)
        {
            InitializeComponent();
            Initialize(combos);
            Map(null);
            InitializeBinding();
        }

        public AlterModal(IDictionary<string, List<ComboItem>> combos, Task task)
        {
            InitializeComponent();
            Initialize(combos);
            Map(task);
            InitializeBinding();
        }

        private void InitializeBinding()
        {
            FormMvvm.SetViewModel(typeof(AlterModalViewModel), _viewModel);

            FormMvvm.SetBinding(ModalTitle, c => c.Text, "Title");
            FormMvvm.SetBinding(CtrlDescription, c => c.Text, "Description");
            FormMvvm.SetBinding(CtrlPriorityId, c => c.EditValue, "PriorityId");
            FormMvvm.SetBinding(CtrlStatusId, c => c.EditValue, "StatusId");
            FormMvvm.SetBinding(CtrlCommitment, c => c.EditValue, "Commitment");
            FormMvvm.SetBinding(CtrlNotes, c => c.Text, "Notes");
        }

        private void Map(Task value)
        {
            if (value != null)
            {
                _viewModel.Id = value.Id;
                _viewModel.Description = value.Description;
                _viewModel.StatusId = value.StatusId;
                _viewModel.PriorityId = value.PriorityId;
                _viewModel.Commitment = value.Commitment;
                _viewModel.Notes = value.Notes;
            }
            else
            {
                var states = CtrlStatusId.Properties.DataSource as List<ComboItem>;
                var stateDefault = states.FirstOrDefault();
                _viewModel.StatusId = stateDefault.Id;
            }
        }        

        private void Initialize(IDictionary<string, List<ComboItem>> combos)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            CtrlCommitment.Properties.MinDate = DateTime.Now;

            CtrlStatusId.Properties.DataSource = combos["STATES"];
            CtrlStatusId.Properties.DisplayMember = "Text";
            CtrlStatusId.Properties.ValueMember = "Id";

            CtrlPriorityId.Properties.DataSource = combos["PRIORITIES"];
            CtrlPriorityId.Properties.DisplayMember = "Text";
            CtrlPriorityId.Properties.ValueMember = "Id";
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
                DialogResult = DialogResult.OK;
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
