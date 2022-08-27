using HungryPizza.Domain.Entities;
using HungryPizza.Persistence.Contexts;
using HungryPizza.Persistence.Interfaces;
using System.Data;

namespace HungryPizza.Persistence.Repositories;
public class PizzaFlavorsPriceRepository : BaseRepository<PizzaFlavorsPriceEntity>, IPizzaFlavorsPriceRepository
{
    public PizzaFlavorsPriceRepository(IDbConnection connection, DBHungryPizzaContext databaseContext)
        : base(connection, databaseContext)
    {

    }

    Task<bool> IBaseRepository<PizzaFlavorsPriceEntity>.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<PizzaFlavorsPriceEntity> IBaseRepository<PizzaFlavorsPriceEntity>.GetOne(int id)
    {
        throw new NotImplementedException();
    }
}

