namespace NorthWind.Sales.Backend.DataContexts.EFCore.Configurations;

public class OrderDetailConfiguration : IEntityTypeConfiguration<Repositories.Entities.OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.HasKey(d => new { d.OrderId, d.ProductId });
        builder.Property(d => d.UnitPrice)
            .HasPrecision(8, 2);
    }
}