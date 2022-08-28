using HungryPizza.Domain.Contracts.Request;
using HungryPizza.Domain.Entities;

namespace HungryPizza.Domain.Mappers;
public static class PizzaFlavorsMapper
{
    public static PizzaFlavorEntity PizzaFlavorMapper(PizzaFlavorRequest pizzaFlavorResponse)
    {
        return new PizzaFlavorEntity()
        {
            Flavor = pizzaFlavorResponse.Flavor,
            Ingredients = pizzaFlavorResponse.Ingredients,
            Available = pizzaFlavorResponse.Available
        };
    }

    public static PizzaFlavorsPriceEntity PizzaFlavorsPriceMapper(PizzaFlavorRequest pizzaFlavorResponse)
    {
        return new PizzaFlavorsPriceEntity()
        {
            Price = pizzaFlavorResponse.Price,
            Size = pizzaFlavorResponse.Size
        };
    }
}

