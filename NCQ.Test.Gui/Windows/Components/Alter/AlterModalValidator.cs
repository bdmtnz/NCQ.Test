using FluentValidation;
using NCQ.Test.Domain.Tasks;

namespace NCQ.Test.Gui.Windows.Components.Alter
{
    public class AlterModalValidator : AbstractValidator<Task>
    {
        public AlterModalValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .NotNull()
                .MinimumLength(5);

            RuleFor(x => x.Status)
                .NotNull();

            RuleFor(x => x.Priority)
                .NotNull();

            RuleFor(x => x.Commitment)
                .NotNull();
        }
    }
}
