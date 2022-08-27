using HungryPizza.Service.Interfaces;
using HungryPizza.API.Contracts.Response;
using HungryPizza.API.Mappers;
using HungryPizza.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HungryPizza.API.EndPoints;
public static class OrdersEndpoints
{
    public static void AddOrderEndpoints(this WebApplication app)
    {
        app.PizzaEndpoints();
        app.OrderEndpoints();
    }

    public static void PizzaEndpoints(this WebApplication app)
    {
        string RootName = "pizza";
        app.MapGet(RootName + "/listAll", async ([FromServices] IPizzaFlavorService service) =>
            {
                return await service.
            });

        app.MapPost(RootName + "/register", async ([FromServices] IPizzaFlavorService service, [FromBody] PizzaFlavorResponse pizzaFlavorResponse) =>
        {
            PizzaFlavorEntity pizzaFlavorEntity = PizzaFlavorsMapper.PizzaFlavorMapper(pizzaFlavorResponse);
            PizzaFlavorsPriceEntity pizzaFlavorsPriceEntity = PizzaFlavorsMapper.PizzaFlavorsPriceMapper(pizzaFlavorResponse);
            return await service.RegisterPizzaFlavor(pizzaFlavorEntity, pizzaFlavorsPriceEntity);
        });
    }

    public static void OrderEndpoints(this WebApplication app)
    {

    }



}

