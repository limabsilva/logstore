using HungryPizza.Domain.Validators.Interfaces;
using HungryPizza.Domain.Contracts.Request;

namespace HungryPizza.Domain.Validators;
public class ClientRequestValidator : IValidator<ClientRequest>
{
    public ValidatorResponseModel Validate(ClientRequest instance)
    {
        var validatorReponse = new ModelValidator();

        validatorReponse.NotEmpty(instance.Telephone, ValidatorMessages.MandatoryFieldMessage("Telephone"));
        validatorReponse.ExactLenght(instance.Telephone, 11, ValidatorMessages.ExactLenghtNumberFieldMessage("Telephone", 11));
        validatorReponse.NotEmpty(instance.Name, ValidatorMessages.MandatoryFieldMessage("Name"));
        validatorReponse.MaxLenght(instance.Name, 200, ValidatorMessages.MaxLenghtExceededFieldMessage("Name", 200));
        validatorReponse.NotEmpty(instance.StreetName, ValidatorMessages.MandatoryFieldMessage("StreetName"));
        validatorReponse.MaxLenght(instance.StreetName, 200, ValidatorMessages.MaxLenghtExceededFieldMessage("StreetName", 200));
        validatorReponse.IsGreaterThan(instance.Number, 0, ValidatorMessages.MandatoryFieldMessage("Number"));
        validatorReponse.NotEmpty(instance.Neighborhood, ValidatorMessages.MandatoryFieldMessage("Neighborhood"));
        validatorReponse.MaxLenght(instance.Neighborhood, 100, ValidatorMessages.MaxLenghtExceededFieldMessage("Neighborhood", 100));
        validatorReponse.NotEmpty(instance.City, ValidatorMessages.MandatoryFieldMessage("City"));
        validatorReponse.MaxLenght(instance.City, 100, ValidatorMessages.MaxLenghtExceededFieldMessage("City", 100));
        validatorReponse.NotEmpty(instance.State, ValidatorMessages.MandatoryFieldMessage("State"));
        validatorReponse.MaxLenght(instance.State, 100, ValidatorMessages.MaxLenghtExceededFieldMessage("State", 100));
        validatorReponse.NotEmpty(instance.ZipCode, ValidatorMessages.MandatoryFieldMessage("ZipCode"));
        validatorReponse.MaxLenght(instance.ZipCode, 100, ValidatorMessages.MaxLenghtExceededFieldMessage("ZipCode", 20));

        return validatorReponse.Result();
    }
}

