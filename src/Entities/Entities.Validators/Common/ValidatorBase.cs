namespace Entities.Validators;

internal abstract class ValidatorBase<T> : AbstractValidator<T>, IModelValidator<T>
    where T : class
{
    public IEnumerable<ValidationError> Errors { get; private set; } = null!;

    async Task<bool> IModelValidator<T>.Validate(T model)
    {
        var Result = await ValidateAsync(model);

        if (!Result.IsValid)
        {
            Errors = Result.Errors.Select(e => new ValidationError(e.PropertyName, e.ErrorMessage));
        }

        return Result.IsValid;
    }
}
