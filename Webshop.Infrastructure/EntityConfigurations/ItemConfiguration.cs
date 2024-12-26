using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Webshop.Domain.Entities;

namespace Webshop.Infrastructure.EntityConfigurations;
public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(500)");
        builder.Property(x => x.Description).IsRequired().HasColumnType("nvarchar(max)");
        builder.Property(x => x.GrossPrice).IsRequired().HasColumnType("decimal(5, 2)");
        builder.Property(x => x.Currency).IsRequired().HasColumnType("varchar(3)");
        builder.Property(x => x.UnitAmount).IsRequired().HasColumnType("decimal(5, 2)");
        builder.Property(x => x.UnitOfMeasurement).IsRequired().HasColumnType("nvarchar(50)");

    }
}