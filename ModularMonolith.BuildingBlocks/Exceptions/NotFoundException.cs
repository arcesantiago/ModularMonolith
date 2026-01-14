namespace Examples.Core.Exceptions
{
    public class NotFoundException(string name, object key) : ApplicationException($"Entity \"{name}\" ({key}) no fue encontrada")
    {
    }
}
