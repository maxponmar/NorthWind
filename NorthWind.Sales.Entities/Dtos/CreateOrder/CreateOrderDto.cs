namespace NorthWind.Sales.Entities.Dtos.CreateOrder;

public class CreateOrderDto(
    string customerId, string shipAddress, string shipCity, string shipCountry,
    string shipZipCode, IEnumerable<CreateOrderDetailDto> orderDetails)
{
    public string CustomerId => customerId;
    public string ShipAddress => shipAddress;
    public string ShipCity => shipCity;
    public string ShipCountry => shipCountry;
    public string ShipZipCode => shipZipCode;
    public IEnumerable<CreateOrderDetailDto> OrderDetails => orderDetails;
}