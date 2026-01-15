using FluentValidation;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.UpdateExample
{
    public class UpdateExampleCommandValidator : AbstractValidator<UpdateExampleCommand>
    {
        public UpdateExampleCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Id must be greater than 0.");
        }
    }
}
