using Dapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using HungryPizza.Persistence.Contexts;
using System.Data;

namespace HungryPizza.Persistence.Repositories;
public class BaseRepository<T> where T : class
{
    protected readonly IDbConnection _connection;
    protected readonly DBHungryPizzaContext _databaseContext;

    public BaseRepository(IDbConnection connection, DBHungryPizzaContext databaseContext)
    {
        _databaseContext = databaseContext;
        _connection = connection;
    }

    public BaseRepository(DBHungryPizzaContext databaseContext)
    {
        this._databaseContext = databaseContext;
    }

    public virtual async Task<Result> SaveChanges()
    {
        try
        {
            await this._databaseContext.SaveChangesAsync();
            return Result.Ok();
        }
        catch (DbUpdateException ex)
        {
            return Result.Fail(ex.Message.ToString());
        }
    }

    public async Task Delete(T model)
    {
        _databaseContext.Set<T>().Remove(model);
    }

    public virtual async Task Create(T model)
    {
        await this._databaseContext.Set<T>().AddAsync(model);
    }

    public virtual Task Update(T model)
    {
        this._databaseContext.Entry(model).State = EntityState.Modified;
        return Task.CompletedTask;
    }

    protected async Task<TProject> QueryOne<TProject>(string sqlCommand, object parameters = null)
    {
        return await _connection.QuerySingleOrDefaultAsync<TProject>(sqlCommand, parameters);
    }

    protected async Task<IEnumerable<TProject>> QueryMany<TProject>(string sqlCommand, object parameters = null)
    {
        return await _connection.QueryAsync<TProject>(sqlCommand, parameters);
    }

    protected async Task<int> ExecuteEscalar(string sqlCommand, object parameters = null)
    {
        return await _connection.ExecuteScalarAsync<int>(sqlCommand, parameters);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _databaseContext.Set<T>().ToListAsync();
    }
}

