namespace Entities.Abstractions.Interfaces
{
    public interface IModelValidator<T>
        where T : class
    {
        Task<bool> Validate(T model);
        IEnumerable<ValidationError> Errors { get; }
    }
}
