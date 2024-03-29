namespace NorthWind.Validation.Entities.Interfaces;

public interface IModelValidator<T>
{
    ValidationConstraint Constraint { get; }
    IEnumerable<ValidationError> Errors { get; }
    Task<bool> ValidateAsync(T model);
}