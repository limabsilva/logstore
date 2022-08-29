
namespace HungryPizza.Domain.Validators;
public static class ValidatorMessages
{
    private static string Field_IsMandatory = "Atributo {0} obrigatório.";
    private static string Field_ExceedMaxLenght = "Atributo {0} excede o tamanho máximo de {1} caracteres.";
    private static string Field_ExactLenghtNumber = "Atributo {0} deve ter o tamanho exato de {1} dígitos.";

    public static string MandatoryFieldMessage(string fieldName)
    {
        return String.Format(ValidatorMessages.Field_IsMandatory, fieldName);
    }

    public static string MaxLenghtExceededFieldMessage(string fieldName, int maxLenght)
    {
        return String.Format(ValidatorMessages.Field_ExceedMaxLenght, fieldName, maxLenght);
    }

    public static string ExactLenghtNumberFieldMessage(string fieldName, int numberExact)
    {
        return String.Format(ValidatorMessages.Field_ExactLenghtNumber, fieldName, numberExact);
    }
}

