namespace HungryPizza.Domain.Entities;
public class OrderItemEntity : BaseEntity
{
    public int OrderID { get; set; }
    public OrderEntity? Order { get; set; }
    public string? Comments { get; set; }
    public decimal PriceItem { get; set; }
    public ICollection<ItemFlavorsEntity>? ItemFlavorsOrderList { get; set; }
}
