namespace NorthWind.Sales.Backend.Repositories.Repositories;

internal class CommandsRepository(INorthWindSalesCommandsDataContext context) : ICommandsRepository
{
    public async Task SaveChanges() => await context.SaveChangesAsync();

    public async Task CreateOrder(OrderAggregate order)
    {
        await context.AddOrderAsync(order);

        await context.AddOrderDetailsAsync(
            order.OrderDetails.Select(d => new Entities.OrderDetail
            {
                Order = order,
                ProductId = d.ProductId,
                Quantity = d.Quantity,
                UnitPrice = d.UnitPrice
            }).ToArray());
    }
}