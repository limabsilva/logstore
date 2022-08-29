namespace HungryPizza.Domain.Entities;
public class PizzaFlavorsPriceEntity : BaseEntity
{
    public int? PizzaFlavorEntityID { get; set; }
    public PizzaFlavorEntity? PizzaFlavorEntity { get; set; }
    public decimal Price { get; set; }
    public string? Size { get; set; }
}
