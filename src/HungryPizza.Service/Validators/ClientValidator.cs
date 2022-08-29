using HungryPizza.Domain.Entities;
using HungryPizza.Service.Interfaces;

namespace HungryPizza.Service.Validators;
public class ClientValidator
{
    private readonly IClientService _clientService;
    public ClientValidator(IClientService clientService)
    {
        _clientService = clientService;
    }

    public ClientEntity IsExistsClient(string numberPhone)
    {
        return _clientService.GetClientByTelephone(numberPhone);
    }
}