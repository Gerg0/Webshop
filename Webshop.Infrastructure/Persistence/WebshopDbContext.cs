using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Webshop.Domain.Entities;
using Webshop.Infrastructure.EntityConfigurations;

namespace Webshop.Infrastructure.Persistence;

internal class WebshopDbContext(DbContextOptions<WebshopDbContext> options) : IdentityDbContext<User>(options)
{
    internal DbSet<Item> Items { get; set; }
    internal DbSet<Vat> Vats { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new ItemConfiguration());
        modelBuilder.ApplyConfiguration(new VatConfigurations());
    }
}
