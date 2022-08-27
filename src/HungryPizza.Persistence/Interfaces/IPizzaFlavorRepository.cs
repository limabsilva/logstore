using HungryPizza.Domain.Contracts.Response;
using HungryPizza.Domain.Entities;

namespace HungryPizza.Persistence.Interfaces;
public interface IPizzaFlavorRepository : IBaseRepository<PizzaFlavorEntity>
{
    Task<IEnumerable<PizzasFlavorsResponse>> ListAllPizzas(); 
}