namespace NorthWind.Sales.Frontend.WebApiGateways;

internal class CreateOrderGateway(HttpClient httpClient) : ICreateOrderGateway
{
    public async Task<int> CreateOrderAsync(CreateOrderDto order)
    {
        int orderId = 0;

        var response = await httpClient.PostAsJsonAsync(Endpoints.CreateOrder, order);
        
        if (response.IsSuccessStatusCode)
        {
            orderId = await response.Content.ReadFromJsonAsync<int>();
        }
        return orderId;
    }
}