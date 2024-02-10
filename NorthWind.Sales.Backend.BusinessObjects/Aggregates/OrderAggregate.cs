namespace NorthWind.Sales.Backend.BusinessObjects.Aggregates;

public class OrderAggregate : Order
{
    private readonly List<OrderDetail> _orderDetailsField = [];
    public IReadOnlyCollection<OrderDetail> OrderDetails => _orderDetailsField;
    
    public void AddOrderDetail(int productId, decimal unitPrice, short quantity)
    {
        var existingOrderDetail = _orderDetailsField
            .FirstOrDefault(o => o.ProductId == productId);
        if (existingOrderDetail != default)
        {
            quantity += existingOrderDetail.Quantity;
            _orderDetailsField.Remove(existingOrderDetail);
        }
        _orderDetailsField.Add(new OrderDetail(productId, unitPrice, quantity));
    }

    public static OrderAggregate From(CreateOrderDto orderDto)
    {
        OrderAggregate orderAggregate = new()
        {
            CustomerId = orderDto.CustomerId,
            ShipAddress = orderDto.ShipAddress,
            ShipCity = orderDto.ShipCity,
            ShipCountry = orderDto.ShipCountry,
            ShipZipCode = orderDto.ShipZipCode,
        };

        foreach (var orderDetailDto in orderDto.OrderDetails)
        {
            orderAggregate.AddOrderDetail(orderDetailDto.ProductId, orderDetailDto.UnitPrice, orderDetailDto.Quantity);
        }
        
        return orderAggregate;
    }
}