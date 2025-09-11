using FluentValidation;

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
                .WithMessage("El estado no es válido")
                .GreaterThan(0)
                .WithMessage("El estado no es válido");

            RuleFor(x => x.PriorityId)
                .NotNull()
                .WithMessage("La prioridad no es válida")
                .GreaterThan(0)
                .WithMessage("La prioridad no es válida");

            RuleFor(x => x.Commitment)
                .NotEmpty()
                .WithMessage("La fecha de compromiso no es válida")
                .NotNull()
                .WithMessage("La fecha de compromiso no es válida");
        }
    }
}
