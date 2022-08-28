using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Contracts.Response;
using HungryPizza.Service.Interfaces;
using HungryPizza.Persistence.Interfaces;
using Microsoft.Extensions.Logging;

namespace HungryPizza.Service.Services;
public class PizzaFlavorService : IPizzaFlavorService
{
    private readonly ILogger _logger;
    private readonly IPizzaFlavorRepository _pizzaFlavorRepository;
    private readonly IPizzaFlavorsPriceRepository _pizzaFlavorsPriceRepository;

    public PizzaFlavorService(ILogger<PizzaFlavorService> logger,
        IPizzaFlavorRepository pizzaFlavorRepository,
        IPizzaFlavorsPriceRepository pizzaFlavorsPriceRepository)
    {
        _logger = logger;
        _pizzaFlavorRepository = pizzaFlavorRepository;
        _pizzaFlavorsPriceRepository = pizzaFlavorsPriceRepository;
    }

    public async Task<IEnumerable<PizzasFlavorsResponse>> ListAllPizzas()
    {
        return await _pizzaFlavorRepository.ListAllPizzas();
    }

    public async Task<string> RegisterPizzaFlavor(PizzaFlavorEntity pizzaFlavorEntity, PizzaFlavorsPriceEntity pizzaFlavorsPriceEntity)
    {
        string ret;
        if (pizzaFlavorEntity != null)
        {
            try
            {
                pizzaFlavorEntity.Register = DateTime.Now;
                await _pizzaFlavorRepository.Create(pizzaFlavorEntity);
                var result = await _pizzaFlavorRepository.SaveChangesAsync();
                if (result.IsSuccess)
                {
                    pizzaFlavorsPriceEntity.PizzaFlavorEntityID = pizzaFlavorEntity.Id;
                    pizzaFlavorsPriceEntity.Register = DateTime.Now;
                    await _pizzaFlavorsPriceRepository.Create(pizzaFlavorsPriceEntity);
                    var resultPizzaPrice = await _pizzaFlavorsPriceRepository.SaveChangesAsync();
                    if (resultPizzaPrice.IsSuccess)
                    {
                        ret = "Pizza cadastrada com sucesso!";
                        return ret;
                    }
                    else
                    {
                        _logger.LogError("Falha ao cadastrar ao registrar o preço da pizza: " + result.Errors.ToString());
                        return "Falha ao cadastrar ao registrar o preço da pizza.";
                    }
                }
                else
                {
                    _logger.LogError("Falha ao cadastrar Pizza: " + result.Errors.ToString());
                    return "Falha ao cadastrar Pizza.";
                }
            }
            catch (Exception ex)
            {
                ret = "Falha ao cadastrar Pizza: " + ex.Message;
                _logger.LogError(ret);
                return ret;

            }
        }
        else
        {
            ret = "Objeto [PizzaFlavorEntity] inválido.";
            _logger.LogError(ret);
            return ret;
        }
    }
}

