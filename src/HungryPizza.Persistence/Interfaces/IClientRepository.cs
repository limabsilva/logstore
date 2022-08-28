using HungryPizza.Domain.Entities;

namespace HungryPizza.Persistence.Interfaces;
public interface IClientRepository : IBaseRepository<ClientEntity>
{
    ClientEntity GetClientByTelephone(string phoneNumber);
}

