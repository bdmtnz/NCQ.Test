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
                .WithMessage("La descripción no es válida");

            RuleFor(x => x.Status)
                .NotNull()
                .WithMessage("El estado no es válido");

            RuleFor(x => x.Priority)
                .NotNull()
                .WithMessage("La prioridad no es válida");

            RuleFor(x => x.Commitment)
                .NotEmpty()
                .NotNull()
                .WithMessage("La fecha de compromiso no es válida");
        }
    }
}
