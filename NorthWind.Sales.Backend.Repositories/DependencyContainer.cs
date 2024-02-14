namespace NorthWind.Sales.Backend.Repositories;

public static class DependencyContainer
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICommandsRepository, CommandsRepository>();
        
        return services;
    }
}