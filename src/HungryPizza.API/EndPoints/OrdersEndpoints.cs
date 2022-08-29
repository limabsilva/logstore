using HungryPizza.Service.Interfaces;
using HungryPizza.Domain.Contracts.Request;
using HungryPizza.Domain.Mappers;
using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Validators;
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
                return await service.ListAllPizzas();
            });


        app.MapPost(RootName + "/register", async ([FromServices] IPizzaFlavorService service, [FromBody] PizzaFlavorRequest pizzaFlavorRequest) =>
        {

            var validator = new PizzaFlavorRequestValidator();
            var retValidacao = validator.Validate(pizzaFlavorRequest);
            if (!retValidacao.IsValid)
            {
                var errors = new ErrorResponseModel()
                {
                    Message = "Parâmetros inconsistentes",
                    Errors = retValidacao.Errors
                };
                return errors.ToJson();
            }
            PizzaFlavorEntity pizzaFlavorEntity = PizzaFlavorsMapper.PizzaFlavorMapper(pizzaFlavorRequest);
            PizzaFlavorsPriceEntity pizzaFlavorsPriceEntity = PizzaFlavorsMapper.PizzaFlavorsPriceMapper(pizzaFlavorRequest);
            return await service.RegisterPizzaFlavor(pizzaFlavorEntity, pizzaFlavorsPriceEntity);
        });

    }

    public static void OrderEndpoints(this WebApplication app)
    {
        string RootName = "order";
        app.MapPost(RootName + "/register", async ([FromServices] IOrderService service, [FromBody] OrderRequest orderRequest) =>
        {
            ClientEntity clientEntity = ClientMapper.ClientEntityMapper(orderRequest.Client);
            OrderEntity orderEntity = OrdersMapper.OrderEntityMapper(orderRequest);
            List<OrderItemEntity> orderItemEntities = OrdersMapper.OrderItemEntityMapper(orderRequest);

            if (orderItemEntities == null)
            {
                return "Favor selecione pelo menos 1(um) sabor de pizza para realizar o pedido.";
            }
            var validator = new OrderValidator();
            var retValidacao = validator.Validate(orderRequest);
            if (!retValidacao.IsValid)
            {
                var errors = new ErrorResponseModel()
                {
                    Message = "Parâmetros inconsistentes",
                    Errors = retValidacao.Errors
                };
                return errors.ToJson();
            }
            return await service.RegisterOrder(clientEntity, orderEntity, orderItemEntities);
        });

        app.MapGet(RootName + "/listAllByClient", async ([FromServices] IOrderService service, [FromQuery] string phoneNumber, [FromQuery] int page) =>
        {
            return await service.GetListOrdersByClient(phoneNumber, page);
        });

    }



}

