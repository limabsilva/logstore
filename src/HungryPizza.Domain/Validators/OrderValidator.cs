using HungryPizza.Domain.Validators.Interfaces;
using HungryPizza.Domain.Contracts.Request;

namespace HungryPizza.Domain.Validators;
public class OrderValidator : IValidator<OrderRequest>
{
    public ValidatorResponseModel Validate(OrderRequest instance)
    {
        var validatorReponse = new ModelValidator();

        if (String.IsNullOrEmpty(instance.Client.Telephone))
        {
            validatorReponse.NotEmpty(instance.Client.Name, ValidatorMessages.MandatoryFieldMessage("Name"));
            validatorReponse.MaxLenght(instance.Client.Name, 200, ValidatorMessages.MaxLenghtExceededFieldMessage("Name", 200));
            validatorReponse.NotEmpty(instance.Client.StreetName, ValidatorMessages.MandatoryFieldMessage("StreetName"));
            validatorReponse.MaxLenght(instance.Client.StreetName, 200, ValidatorMessages.MaxLenghtExceededFieldMessage("StreetName", 200));
            validatorReponse.IsGreaterThan(instance.Client.Number, 0, ValidatorMessages.MandatoryFieldMessage("Number"));
            validatorReponse.NotEmpty(instance.Client.Neighborhood, ValidatorMessages.MandatoryFieldMessage("Neighborhood"));
            validatorReponse.MaxLenght(instance.Client.Neighborhood, 100, ValidatorMessages.MaxLenghtExceededFieldMessage("Neighborhood", 100));
            validatorReponse.NotEmpty(instance.Client.City, ValidatorMessages.MandatoryFieldMessage("City"));
            validatorReponse.MaxLenght(instance.Client.City, 100, ValidatorMessages.MaxLenghtExceededFieldMessage("City", 100));
            validatorReponse.NotEmpty(instance.Client.State, ValidatorMessages.MandatoryFieldMessage("State"));
            validatorReponse.MaxLenght(instance.Client.State, 100, ValidatorMessages.MaxLenghtExceededFieldMessage("State", 100));
            validatorReponse.NotEmpty(instance.Client.ZipCode, ValidatorMessages.MandatoryFieldMessage("ZipCode"));
            validatorReponse.MaxLenght(instance.Client.ZipCode, 100, ValidatorMessages.MaxLenghtExceededFieldMessage("ZipCode", 20));
        }
        else
        {
            validatorReponse.ExactLenght(instance.Client.Telephone, 11, ValidatorMessages.ExactLenghtNumberFieldMessage("Telephone", 11));
        }
        return validatorReponse.Result();
    }
}

