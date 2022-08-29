using HungryPizza.Domain.Contracts.Response;
using HungryPizza.Domain.Entities;

namespace HungryPizza.Persistence.Interfaces;
public interface IOrderRepository : IBaseRepository<OrderEntity>
{
    Task<IEnumerable<OrdersListClientResponse>> GetListOrdersByClient(string phoneNumber, int page);
}


