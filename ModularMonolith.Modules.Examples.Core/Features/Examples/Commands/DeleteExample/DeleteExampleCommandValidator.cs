using FluentValidation;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.DeleteExample
{
    public class DeleteExampleCommandValidator : AbstractValidator<DeleteExampleCommand>
    {
        public DeleteExampleCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Id must be greater than 0.");
        }
    }
}
