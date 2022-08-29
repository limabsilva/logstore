using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Contracts.Response;

namespace HungryPizza.Service.Interfaces;
public interface IOrderService
{
    Task<string> RegisterOrder(ClientEntity clientEntity, OrderEntity orderEntity, List<OrderItemEntity> orderItemEntityList);

    Task<IEnumerable<OrdersListClientResponse>> GetListOrdersByClient(string phoneNumber);
}
