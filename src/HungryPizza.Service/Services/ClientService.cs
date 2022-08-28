using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Contracts.Response;
using HungryPizza.Service.Interfaces;
using HungryPizza.Persistence.Interfaces;
using Microsoft.Extensions.Logging;

public class ClientService : IClientService
{
    private readonly ILogger _logger;
    private readonly IClientRepository _clientRepository;

    public ClientService(ILogger<ClientService> logger,
        IClientRepository clientRepository )
    {
        _logger = logger;
        _clientRepository = clientRepository;
    }

    public async Task<string> RegisterClient(ClientEntity clientEntity)
    {
        string ret;
        if (clientEntity != null)
        {
            try
            {
                clientEntity.Register = DateTime.Now;
                await _clientRepository.Create(clientEntity);
                var result = await _clientRepository.SaveChangesAsync();
                if (result.IsSuccess)
                {
                    ret = "Cliente cadastrado com sucesso!";
                    return ret;
                }
                else
                {
                    _logger.LogError("Falha ao cadastrar Cliente: " + result.Errors.ToString());
                    return "Falha ao cadastrar Cliente.";
                }
            }
            catch (Exception ex)
            {
                ret = "Falha ao cadastrar Cliente: " + ex.Message;
                _logger.LogError(ret);
                return ret;

            }
        }
        else
        {
            ret = "Objeto [ClientEntity] inválido.";
            _logger.LogError(ret);
            return ret;
        }
    }
}

