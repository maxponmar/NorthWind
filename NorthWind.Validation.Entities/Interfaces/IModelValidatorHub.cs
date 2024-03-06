namespace NorthWind.Validation.Entities.Interfaces;

public interface IModelValidatorHub<T>
{
    Task<bool> ValidateAsync(T model);
    IEnumerable<ValidationError> Errors { get; }
}