using FluentValidation.Results;

namespace Examples.Core.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public ValidationException() : base("Se presentaron uno o mas errores de validacion")
        {
            Errors = [];
        }

        public ValidationException(IEnumerable<ValidationFailure> failures) : this()
        {
            Errors = failures.GroupBy(e => e.PropertyName, e => e.ErrorMessage)
                .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
        }
        public Dictionary<string, string[]> Errors { get; set; }

    }
}
