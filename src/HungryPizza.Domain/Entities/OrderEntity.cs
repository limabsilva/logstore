
namespace HungryPizza.Domain.Entities;
public class OrderEntity : BaseEntity
{
    public int ClientID { get; set; }
    public ClientEntity? Client { get; set; }
    public string? Description { get; set; }
    public decimal PriceTotal { get; set; }
    public ICollection<OrderItemEntity>? OrderItems { get; set; }

}
