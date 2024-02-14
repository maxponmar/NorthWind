namespace NorthWind.Sales.Backend.UseCases.CreateOrder;

internal class CreateOrderInteractor(
    ICreateOrderOutputPort outputPort, 
    ICommandsRepository commandsRepository) : ICreateOrderInputPort
{
    public async Task Handle(CreateOrderDto orderDto)
    {
        OrderAggregate order = OrderAggregate.From(orderDto);
        
        await commandsRepository.CreateOrder(order);
        await commandsRepository.SaveChanges();

        await outputPort.Handle(order);
    }
}