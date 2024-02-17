namespace NorthWind.Sales.Backend.DataContexts.EFCore.Configurations;

internal class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.Property(o => o.CustomerId)
            .IsRequired()
            .HasMaxLength(5)
            .IsFixedLength();
        
        builder.Property(o => o.ShipAddress)
            .IsRequired()
            .HasMaxLength(60);
        
        builder.Property(o => o.ShipCity)
            .IsRequired()
            .HasMaxLength(15);
        
        builder.Property(o => o.ShipCountry)
            .IsRequired()
            .HasMaxLength(25);
        
        builder.Property(o => o.ShipZipCode)
            .IsRequired()
            .HasMaxLength(10);
    }
}