namespace HungryPizza.Domain.Contracts.Request;
public class PizzaFlavorRequest
{
    public string? Flavor { get; set; }
    public string? Ingredients { get; set; }
    public bool Available { get; set; }
    public decimal Price { get; set; }
    public string? Size { get; set; }
}
