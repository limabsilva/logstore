using HungryPizza.API.Contracts.Response;
using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Enums;

namespace HungryPizza.API.Mappers
{
    public static class PizzaFlavorsMapper
    {
        public static PizzaFlavorEntity PizzaFlavorMapper(PizzaFlavorResponse pizzaFlavorResponse)
        {
            return new PizzaFlavorEntity()
            {
                Flavor = pizzaFlavorResponse.Flavor,
                Ingredients = pizzaFlavorResponse.Ingredients,
                Available = pizzaFlavorResponse.Available
            };
        }

        public static PizzaFlavorsPriceEntity PizzaFlavorsPriceMapper(PizzaFlavorResponse pizzaFlavorResponse)
        {
            return new PizzaFlavorsPriceEntity()
            {
                Price = pizzaFlavorResponse.Price,
                Size = pizzaFlavorResponse.Size
            };
        }
    }
}
