namespace NorthWind.Sales.Frontend.Views;

public static class DependencyContainer
{
    public static IServiceCollection AddViewsServices(this IServiceCollection services)
    {
        services.AddScoped<CreateOrderViewModel>();
        return services;
    }
}