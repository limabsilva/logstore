using HungryPizza.Domain.Entities;
using HungryPizza.Persistence.Contexts;
using HungryPizza.Persistence.Interfaces;
using System.Data;

namespace HungryPizza.Persistence.Repositories;
public class OrderItemRepository : BaseRepository<OrderItemEntity>, IOrderItemRepository
{
    public OrderItemRepository(IDbConnection connection, DBHungryPizzaContext databaseContext)
        : base(connection, databaseContext)
    {

    }

    Task<bool> IBaseRepository<OrderItemEntity>.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<OrderItemEntity> IBaseRepository<OrderItemEntity>.GetOne(int id)
    {
        throw new NotImplementedException();
    }
}

