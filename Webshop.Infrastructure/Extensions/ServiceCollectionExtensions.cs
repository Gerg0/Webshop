using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Webshop.Domain.Entities;
using Webshop.Infrastructure.Persistence;
using Webshop.Infrastructure.Seeders;

namespace Webshop.Infrastructure.Extensions;
public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("WebshopDb");
        services.AddDbContext<WebshopDbContext>(options => options.UseSqlServer(connectionString));
        services.AddIdentityApiEndpoints<User>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<WebshopDbContext>();

        services.AddScoped<ISeeder, VatsSeeder>();
        services.AddScoped<ISeeder, IdentityRolesSeeder>();
        services.AddScoped<ISeeder, ItemSeeder>();
    }
}
