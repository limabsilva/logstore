using HungryPizza.Domain.Entities;
using HungryPizza.Persistence.Contexts;
using HungryPizza.Persistence.Interfaces;
using System.Data;

namespace HungryPizza.Persistence.Repositories;
public class OrderRepository : BaseRepository<OrderEntity>, IOrderRepository
{
    public OrderRepository(IDbConnection connection, DBHungryPizzaContext databaseContext)
        : base(connection, databaseContext)
    {

    }

    Task<bool> IBaseRepository<OrderEntity>.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<OrderEntity> IBaseRepository<OrderEntity>.GetOne(int id)
    {
        throw new NotImplementedException();
    }
}

