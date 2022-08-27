using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HungryPizza.Persistence.Contexts;

namespace HungryPizza.Persistence;
public static class PersitenceDependecy
{
    public static void AddSqlModule(this IServiceCollection services, IConfiguration configuration)
    {
        SqlDatabaseConfiguration(services, configuration);
        ConfigureRepositories(services);
    }

    private static void SqlDatabaseConfiguration(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextFactory<DBHungryPizzaContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DBHungryPizza")));
        services.AddScoped<DBHungryPizzaContext, DBHungryPizzaContext>();

        services.AddScoped<IDbConnection, SqlConnection>(factory =>
        {
            var connection = new SqlConnection(configuration.GetConnectionString("DBHungryPizza"));
            connection.Open();

            return connection;
        });
    }
    private static void ConfigureRepositories(IServiceCollection services)
    {
        //services.AddScoped<ICarCategoryRepository, CarCategoryRepository>();
    }
}

