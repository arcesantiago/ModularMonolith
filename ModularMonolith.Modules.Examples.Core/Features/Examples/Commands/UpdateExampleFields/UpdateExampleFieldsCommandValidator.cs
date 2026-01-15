using FluentValidation;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.UpdateExampleFields
{
    public class UpdateExampleFieldsCommandValidator : AbstractValidator<UpdateExampleFieldsCommand>
    {
        public UpdateExampleFieldsCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Id must be greater than 0.");
        }
    }
}
