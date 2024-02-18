namespace NorthWind.Sales.Backend.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddNorthWindSalesServices(
        this IServiceCollection services, 
        Action<DBOptions> configureDbOptions)
    {
        services.AddUseCasesServices()
            .AddRepositories()
            .AddDataContexts(configureDbOptions)
            .AddPresenters();
        return services;
    }
}