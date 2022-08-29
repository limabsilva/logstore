
namespace HungryPizza.Domain.Entities;
public class ItemFlavorsEntity : BaseEntity
{
    public int OrderItemID { get; set; }
    public OrderItemEntity? OrderItem { get; set; }
    public int PizzaFlavorID { get; set; }
    public PizzaFlavorEntity? PizzaFlavor { get; set; }
}

