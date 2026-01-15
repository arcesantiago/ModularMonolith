using MediatR;
using System.Linq.Expressions;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.UpdateExampleFields
{
    public record UpdateExampleFieldsCommand(
        int Id
    ) : IRequest<int>;
}
