using FluentValidation;
using NCQ.Test.Domain.Tasks;

namespace NCQ.Test.Gui.Windows.Components.Alter
{
    public class AlterModalValidator : AbstractValidator<AlterModalViewModel>
    {
        public AlterModalValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("La descripción no es válida")
                .NotNull()
                .WithMessage("La descripción no es válida");

            RuleFor(x => x.StatusId)
                .NotNull()
                .WithMessage("El estado no es válido");

            RuleFor(x => x.PriorityId)
                .NotNull()
                .WithMessage("La prioridad no es válida");

            RuleFor(x => x.Commitment)
                .NotEmpty()
                .WithMessage("La fecha de compromiso no es válida")
                .NotNull()
                .WithMessage("La fecha de compromiso no es válida");
        }
    }
}
