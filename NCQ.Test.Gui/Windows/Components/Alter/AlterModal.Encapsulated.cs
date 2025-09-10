using Mapster;
using NCQ.Test.Domain.Tasks;
using NCQ.Test.Gui.Domain.Common.Contracts.Gui;

namespace NCQ.Test.Gui.Windows.Components.Alter
{
    public partial class AlterModal : IValueModal<Task>
    {
        public Task GetValue()
        {
            var value = FormMvvm.GetViewModel<AlterModalViewModel>();
            return value.Adapt<Task>();
        }

        public bool IsValid()
        {
            var value = FormMvvm.GetViewModel<AlterModalViewModel>();
            var result = new AlterModalValidator().Validate(value);
            return result.IsValid;
        }
    }
}
