
namespace HungryPizza.Domain.Validators.Interfaces;
public interface IValidator<T>
{
    ValidatorResponseModel Validate(T instance);
}
