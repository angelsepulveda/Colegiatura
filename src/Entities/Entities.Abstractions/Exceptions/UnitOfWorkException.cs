namespace Entities.Abstractions.Exceptions;

public class UnitOfWorkException : Exception
{
    public UnitOfWorkException() { }

    public UnitOfWorkException(string message)
        : base(message) { }

    public UnitOfWorkException(string message, Exception innerException)
        : base(message, innerException) { }

    public IEnumerable<string> Entities { get; } = null!;

    public UnitOfWorkException(Exception exception, IEnumerable<string> entities)
        : base(exception.Message, exception) => Entities = entities;
}
