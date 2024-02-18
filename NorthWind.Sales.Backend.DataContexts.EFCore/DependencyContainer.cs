namespace NorthWind.Sales.Backend.DataContexts.EFCore;

public static class DependencyContainer
{
    public static IServiceCollection AddDataContexts(
        this IServiceCollection services, 
        Action<DBOptions> configureDbOptions)
    {
        services.Configure(configureDbOptions);

        services.AddScoped<INorthWindSalesCommandsDataContext, NorthWindSalesCommandsDataContext>();
        
        return services;
    }
}