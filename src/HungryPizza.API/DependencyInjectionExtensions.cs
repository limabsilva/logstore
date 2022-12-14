using HungryPizza.Persistence;
using HungryPizza.Service;

namespace HungryPizza.API
{
    public static class DependencyInjectionExtensions
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddServiceModule();
            services.AddSqlModule(configuration);
        }
    }
}
