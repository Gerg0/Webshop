using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Webshop.Domain.Entities;

namespace Webshop.Infrastructure.EntityConfigurations;
public class VatConfigurations : IEntityTypeConfiguration<Vat>
{
    public void Configure(EntityTypeBuilder<Vat> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.CODE).IsRequired().HasColumnType("nvarchar(10)");
        builder.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(10)");
        builder.Property(x => x.Value).IsRequired().HasColumnType("decimal(5, 2)");
        builder.HasMany(x => x.Items).WithOne(x => x.Vat).HasForeignKey(x => x.VatId).IsRequired().OnDelete(DeleteBehavior.NoAction);
    }
}