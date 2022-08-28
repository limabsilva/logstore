using HungryPizza.Service.Interfaces;
using HungryPizza.Domain.Contracts.Request;
using HungryPizza.Domain.Mappers;
using HungryPizza.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HungryPizza.API.EndPoints
{
    public static class ClientEndpoints
    {
        public static void AddClientEndpoints(this WebApplication app)
        {
            string RootName = "client";

            app.MapPost(RootName + "/register", async ([FromServices] IClientService service, [FromBody] ClientRequest clientRequest) =>
            {
                ClientEntity clientEntity = ClientMapper.ClientEntityMapper(clientRequest);
                return await service.RegisterClient(clientEntity);
            });
        }
    }
}
