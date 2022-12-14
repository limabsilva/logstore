
namespace HungryPizza.Domain.Entities;
public class PizzaFlavorEntity : BaseEntity
{
    public string? Flavor { get; set; }
    public string? Ingredients { get; set; }
    public bool? Available { get; set; }
    public ICollection<PizzaFlavorsPriceEntity>? PizzaFlavorsPrices { get; set; }
    public ICollection<ItemFlavorsEntity>? ItemFlavorsList { get; set; }
}


