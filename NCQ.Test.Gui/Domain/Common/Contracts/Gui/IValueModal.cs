using FluentValidation.Results;

namespace NCQ.Test.Gui.Domain.Common.Contracts.Gui
{
    public interface IValueModal<T>
    {
        ValidationResult IsValid();
        T GetValue();
    }
}
