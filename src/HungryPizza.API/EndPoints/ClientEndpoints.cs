using HungryPizza.Service.Interfaces;
using HungryPizza.Domain.Contracts.Request;
using HungryPizza.Domain.Mappers;
using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Validators;
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
                var validator = new ClientRequestValidator();
                var retValidacao = validator.Validate(clientRequest);
                if (!retValidacao.IsValid)
                {
                    var errors = new ErrorResponseModel()
                    {
                        Message = "Parâmetros inconsistentes",
                        Errors = retValidacao.Errors
                    };
                    return errors.ToJson();
                }

                ClientEntity clientEntity = ClientMapper.ClientEntityMapper(clientRequest);
                return await service.RegisterClient(clientEntity);
            });

            app.MapGet(RootName + "/getByTelephone", async ([FromServices] IClientService service, [FromQuery] string telephone) =>
            {
                return service.GetClientByTelephone(telephone);
            });
        }
    }
}
