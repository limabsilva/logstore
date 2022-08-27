using HungryPizza.Domain.Entities;
using HungryPizza.Persistence.Contexts;
using HungryPizza.Persistence.Interfaces;
using System.Data;

namespace HungryPizza.Persistence.Repositories;
public class PizzaFlavorRepository : BaseRepository<PizzaFlavorEntity>, IPizzaFlavorRepository
{
    public PizzaFlavorRepository(IDbConnection connection, DBHungryPizzaContext databaseContext)
        : base(connection, databaseContext)
    {

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

