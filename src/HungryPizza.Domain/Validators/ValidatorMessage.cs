
namespace HungryPizza.Domain.Validators;
public static class ValidatorMessages
{
    private static string Field_IsMandatory = "Atributo {0} obrigatório.";
    private static string Field_ExceedMaxLenght = "Atributo {0} excede o tamanho máximo de {1} caracteres.";

    public static string MandatoryFieldMessage(string fieldName)
    {
        return String.Format(ValidatorMessages.Field_IsMandatory, fieldName);
    }

    public static string MaxLenghtExceededFieldMessage(string fieldName, int maxLenght)
    {
        return String.Format(ValidatorMessages.Field_ExceedMaxLenght, fieldName, maxLenght);
    }
}

