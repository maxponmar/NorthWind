namespace NorthWind.Sales.Frontend.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddNorthWindSalesServices(
        this IServiceCollection services, 
        Action<HttpClient> configureHttpClient)
    {
        services.AddWebApiGateways(configureHttpClient)
            .AddViewsServices();
        
        return services;
    }
}