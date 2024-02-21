namespace NorthWind.Sales.Frontend.Views.Pages;

public partial class CreateOrder
{
    [Inject]
    CreateOrderViewModel ViewModel { get; set; }

    private ErrorBoundary ErrorBoundaryRef;

    void Recover()
    {
        ErrorBoundaryRef?.Recover();
    }
}