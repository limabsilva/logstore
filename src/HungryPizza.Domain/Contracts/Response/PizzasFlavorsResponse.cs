namespace HungryPizza.Domain.Contracts.Response;
public class PizzasFlavorsResponse
{
    public int PizzaFlavorID { get; set; }
    public string? Flavor { get; set; }
    public string? Ingredients { get; set; }
    public bool Available { get; set; }
    public decimal PricePizza { get; set; }
    public string? SizePizza { get; set; }
}


