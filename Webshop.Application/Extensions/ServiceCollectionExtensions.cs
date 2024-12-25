using Microsoft.Extensions.DependencyInjection;
using Webshop.Application.Users;

namespace Webshop.Application.Extensions;
public static class ServiceCollectionExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserContext, UserContext>();
        services.AddHttpContextAccessor();
    }
}
