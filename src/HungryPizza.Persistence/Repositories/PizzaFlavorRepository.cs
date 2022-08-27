using Dapper;
using HungryPizza.Domain.Contracts.Response;
using HungryPizza.Domain.Entities;
using HungryPizza.Persistence.Contexts;
using HungryPizza.Persistence.Interfaces;
using HungryPizza.Persistence.Query;
using Newtonsoft.Json;
using System.Data;

namespace HungryPizza.Persistence.Repositories;
public class PizzaFlavorRepository : BaseRepository<PizzaFlavorEntity>, IPizzaFlavorRepository
{
    public PizzaFlavorRepository(IDbConnection connection, DBHungryPizzaContext databaseContext)
        : base(connection, databaseContext)
    {
    }

    public async Task<IEnumerable<PizzasFlavorsResponse>> ListAllPizzas()
    {           
        var ret = await QueryMany<PizzasFlavorsResponse>(QuerySQL.ListAllPizzas);
        return ret;
    }
    Task<bool> IBaseRepository<PizzaFlavorEntity>.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<PizzaFlavorEntity> IBaseRepository<PizzaFlavorEntity>.GetOne(int id)
    {
        throw new NotImplementedException();
    }
}

