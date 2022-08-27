using HungryPizza.Domain.Enums;
namespace HungryPizza.API.Contracts.Response;
public class PizzaFlavorResponse
{
    public string? Flavor { get; set; }
    public string? Ingredients { get; set; }
    public bool Available { get; set; }
    public decimal Price { get; set; }
    public string? Size { get; set; }
}
