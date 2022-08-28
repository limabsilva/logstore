using HungryPizza.Domain.Validators.Interfaces;
using HungryPizza.Domain.Contracts.Request;

namespace HungryPizza.Domain.Validators;
public class PizzaFlavorRequestValidator : IValidator<PizzaFlavorRequest>
{
    public ValidatorResponseModel Validate(PizzaFlavorRequest instance)
    {
        var validatorReponse = new ModelValidator();

        validatorReponse.NotEmpty(instance.Flavor, ValidatorMessages.MandatoryFieldMessage("Flavor"));
        validatorReponse.MaxLenght(instance.Flavor, 200, ValidatorMessages.MaxLenghtExceededFieldMessage("Flavor", 200));
        validatorReponse.NotEmpty(instance.Ingredients, ValidatorMessages.MandatoryFieldMessage("Ingredients"));
        validatorReponse.MaxLenght(instance.Ingredients, 500, ValidatorMessages.MaxLenghtExceededFieldMessage("Ingredients", 500));            
        validatorReponse.IsGreaterThan(instance.Price, 0, ValidatorMessages.MandatoryFieldMessage("Price"));
        validatorReponse.NotEmpty(instance.Size, ValidatorMessages.MandatoryFieldMessage("Size"));
        validatorReponse.MaxLenght(instance.Size, 20, ValidatorMessages.MaxLenghtExceededFieldMessage("Size", 20));
        
        return validatorReponse.Result();
    }
}
