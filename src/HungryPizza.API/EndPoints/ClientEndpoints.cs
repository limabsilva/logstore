using HungryPizza.Service.Interfaces;
using HungryPizza.Domain.Contracts.Request;
using HungryPizza.Domain.Mappers;
using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Validators;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HungryPizza.API.EndPoints
{
    public static class ClientEndpoints
    {
        public static void AddClientEndpoints(this WebApplication app)
        {
            string RootName = "client";

            app.MapPost(RootName + "/register", async ([FromServices] IClientService service, [FromBody] ClientRequest clientRequest) =>
            {
                try
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
                }
                catch (Exception ex)
                {                    
                    return "JSON incompatível. Favor verifique o corpo da sua requisição.";
                }

                ClientEntity clientEntity = ClientMapper.ClientEntityMapper(clientRequest);
                return await service.RegisterClient(clientEntity);
            });
        }
    }
}
