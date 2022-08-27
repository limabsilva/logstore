using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Contracts.Response;

namespace HungryPizza.Service.Interfaces;
public interface IPizzaFlavorService
{
    Task<IEnumerable<PizzasFlavorsResponse>> ListAllPizzas();

    Task<string> RegisterPizzaFlavor(PizzaFlavorEntity pizzaFlavorEntity, PizzaFlavorsPriceEntity pizzaFlavorsPriceEntity);
}

