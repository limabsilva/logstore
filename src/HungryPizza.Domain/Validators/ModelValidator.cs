using HungryPizza.Domain.Validators.Interfaces;

namespace HungryPizza.Domain.Validators;
public class ModelValidator
{
    private readonly ValidatorResponseModel _response = new ValidatorResponseModel();

    public void IsGreaterThan(decimal value, int limit, string errorMessage)
    {
        if (value <= limit)
            _response.Errors.Add(errorMessage);
    }

    public void NotEmpty(string value, string errorMessage)
    {
        if (string.IsNullOrEmpty(value))
            _response.Errors.Add(errorMessage);
    }

    public void NotNullOrZero(int? value, string errorMessage)
    {
        if (value == null || value.Value == 0)
            _response.Errors.Add(errorMessage);
    }

    public void MaxLenght(string value, int limit, string errorMessage)
    {
        if (value.Length > limit)
            _response.Errors.Add(errorMessage);
    }
    public void ExactLenght(string value, int numberExact, string errorMessage)
    {
        if (value.Length != numberExact)
            _response.Errors.Add(errorMessage);
    }

    public void ApplyValidator<T>(T instance, IValidator<T> validator, string errorMessage)
    {
        if (instance == null)
        {
            _response.Errors.Add(errorMessage);
        }
        else
        {
            var validatorResponse = validator.Validate(instance);
            if (validatorResponse.IsValid == false)
            {
                _response.Errors.Add(errorMessage);
                _response.Errors = _response.Errors.Concat(validatorResponse.Errors).ToList();
            }
        }
    }

    public ValidatorResponseModel Result()
    {
        return _response;
    }
}

public class ValidatorResponseModel
{
    public ValidatorResponseModel()
    {
        this.Errors = new List<string>();
    }
    public bool IsValid { get { return !this.Errors.Any(); } }
    public List<string> Errors { get; set; }
}

