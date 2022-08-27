using HungryPizza.Domain.Entities;

namespace HungryPizza.Service.Interfaces;
public interface IPizzaFlavorService
{
    ICollection<PizzaFlavorEntity> GetAll();

    Task<string> RegisterPizzaFlavor(PizzaFlavorEntity pizzaFlavorEntity, PizzaFlavorsPriceEntity pizzaFlavorsPriceEntity);
}

