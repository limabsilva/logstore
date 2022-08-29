using FluentResults;

namespace HungryPizza.Persistence.Interfaces;
public interface IBaseRepository<T> where T : class
{
    Task Create(T entity);
    Task Update(T entity);
    Task Delete(T entity);

    Task<bool> Delete(int id);

    Task<T> GetOne(int id);
    Task<IEnumerable<T>> GetAll();
    Task<Result> SaveChangesAsync();    
}
