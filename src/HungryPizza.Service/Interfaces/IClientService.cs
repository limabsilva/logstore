using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Contracts.Response;

namespace HungryPizza.Service.Interfaces;
public interface IClientService
{
    Task<string> RegisterClient(ClientEntity clientEntity);
}

