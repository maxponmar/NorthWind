namespace NorthWind.Sales.Frontend.Views.ViewModels.CreateOrder;

public class CreateOrderViewModel(ICreateOrderGateway gateway)
{
    public string CustomerId { get; set; }
    public string ShipAddress { get; set; }
    public string ShipCity { get; set; }
    public string ShipCountry { get; set; }
    public string ShipZipCode { get; set; }
    public ICollection<CreateOrderDetailViewModel> OrderDetails { get; set; } = [];
    
    public string InformationMessage { get; private set; }

    public void AddNewOrderDetailItem()
    {
        OrderDetails.Add(new CreateOrderDetailViewModel());
    }

    public async Task Send()
    {
        InformationMessage = string.Empty;
        var orderId = await gateway.CreateOrderAsync((CreateOrderDto)this);
        InformationMessage = string.Format(CreateOrderMessages.CreateOrderTemplate, orderId);
    }

    public static explicit operator CreateOrderDto(CreateOrderViewModel viewModel)
        => new CreateOrderDto(
            viewModel.CustomerId,
            viewModel.ShipAddress,
            viewModel.ShipCity,
            viewModel.ShipCountry,
            viewModel.ShipZipCode,
            viewModel.OrderDetails.Select(x 
                => new CreateOrderDetailDto(x.ProductId, x.UnitPrice, x.Quantity)));
}