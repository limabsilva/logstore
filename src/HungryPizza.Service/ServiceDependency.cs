using HungryPizza.Service.Interfaces;
using HungryPizza.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HungryPizza.Service;
public static class ServiceDependency
{
    public static void AddServiceModule(this IServiceCollection services)
    {
        services.AddTransient<IPizzaFlavorService, PizzaFlavorService>();
        services.AddTransient<IClientService, ClientService>();
        services.AddTransient<IOrderService, OrderService>();
    }
}