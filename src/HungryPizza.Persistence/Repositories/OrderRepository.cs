using Dapper;
using HungryPizza.Domain.Contracts.Response;
using HungryPizza.Domain.Entities;
using HungryPizza.Persistence.Contexts;
using HungryPizza.Persistence.Interfaces;
using HungryPizza.Persistence.Query;
using System.Data;

namespace HungryPizza.Persistence.Repositories;
public class OrderRepository : BaseRepository<OrderEntity>, IOrderRepository
{
    public OrderRepository(IDbConnection connection, DBHungryPizzaContext databaseContext)
        : base(connection, databaseContext)
    {

    }

    public async Task<IEnumerable<OrdersListClientResponse>> GetListOrdersByClient(string phoneNumber)
    {
        var parameters = new DynamicParameters();
        parameters.Add("@PhoneNumber", phoneNumber);
        var ret = await QueryMany<OrdersListClientResponse>(QuerySQL.GetAllOrdersByClient, parameters);
        return ret;
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

