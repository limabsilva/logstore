namespace HungryPizza.Domain.Contracts.Request;
public class ClientRequest
{
    public string? Telephone { get; set; }
    public string? Name { get; set; }
    public string? StreetName { get; set; }
    public int Number { get; set; }
    public string? Complement { get; set; }
    public string? Neighborhood { get; set; }
    public string? State { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
}

