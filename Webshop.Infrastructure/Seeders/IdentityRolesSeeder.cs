using Microsoft.AspNetCore.Identity;
using Webshop.Domain.Constants;
using Webshop.Infrastructure.Persistence;

namespace Webshop.Infrastructure.Seeders;
internal class IdentityRolesSeeder(WebshopDbContext dbContext) : ISeeder
{
    public async Task Seed()
    {
        if (await dbContext.Database.CanConnectAsync())
        {
            if (!dbContext.Roles.Any())
            {
                var roles = GetRoles();
                dbContext.Roles.AddRange(roles);
                await dbContext.SaveChangesAsync();
            }
        }
    }

    private IEnumerable<IdentityRole> GetRoles()
    {
        List<IdentityRole> roles =
        [
            new(UserRoles.Customer),
            new(UserRoles.Admin),
        ];
        return roles;
    }
}