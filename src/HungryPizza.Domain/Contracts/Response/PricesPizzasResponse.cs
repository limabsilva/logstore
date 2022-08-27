using HungryPizza.Domain.Entities;
namespace HungryPizza.Domain.Contracts.Response;

public class PricesPizzasResponse
{
    public decimal PricePizza { get; set; }
    public string? SizePizza { get; set; }
}

