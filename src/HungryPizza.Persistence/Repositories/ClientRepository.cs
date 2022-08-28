using HungryPizza.Domain.Entities;
using HungryPizza.Persistence.Contexts;
using HungryPizza.Persistence.Interfaces;
using FluentResults;
using System.Data;

namespace HungryPizza.Persistence.Repositories;
public class ClientRepository : BaseRepository<ClientEntity>, IClientRepository
{
    public ClientRepository(IDbConnection connection, DBHungryPizzaContext databaseContext) 
        : base(connection, databaseContext)
    {

    }

    Task<bool> IBaseRepository<ClientEntity>.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<ClientEntity> IBaseRepository<ClientEntity>.GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public ClientEntity GetClientByTelephone(string phoneNumber)
    {        
        var client = _databaseContext.Client.Where(w => w.Telephone == phoneNumber).FirstOrDefault();
        return client;
    }
}

