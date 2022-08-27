using HungryPizza.Domain.Entities;
using HungryPizza.Persistence.Contexts;
using HungryPizza.Persistence.Interfaces;
using System.Data;

namespace HungryPizza.Persistence.Repositories;
public class ItemFlavorsRepository : BaseRepository<ItemFlavorsEntity>, IItemFlavorsRepository
{
    public ItemFlavorsRepository(IDbConnection connection, DBHungryPizzaContext databaseContext)
        : base(connection, databaseContext)
    {

    }

    Task<bool> IBaseRepository<ItemFlavorsEntity>.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<ItemFlavorsEntity> IBaseRepository<ItemFlavorsEntity>.GetOne(int id)
    {
        throw new NotImplementedException();
    }
}

