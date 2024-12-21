﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Webshop.Infrastructure.Persistence;

namespace Webshop.Infrastructure.Extensions;
public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("WebshopDb");
        services.AddDbContext<WebshopDbContext>(options => options.UseSqlServer(connectionString));
    }
}