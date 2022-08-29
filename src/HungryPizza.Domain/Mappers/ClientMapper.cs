using HungryPizza.Domain.Contracts.Request;
using HungryPizza.Domain.Entities;

namespace HungryPizza.Domain.Mappers;
public static class ClientMapper
{
    public static ClientEntity ClientEntityMapper(ClientRequest clientRequest)
    {
        return new ClientEntity()
        {
            Telephone = clientRequest.Telephone,
            Name = clientRequest.Name,
            StreetName = clientRequest.StreetName,
            Number = clientRequest.Number,
            Complement = clientRequest.Complement,
            Neighborhood = clientRequest.Neighborhood,
            City = clientRequest.City,
            State = clientRequest.State,
            ZipCode = clientRequest.ZipCode
        };
    }
}

