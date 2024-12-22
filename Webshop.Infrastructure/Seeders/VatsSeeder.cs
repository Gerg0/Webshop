using Webshop.Domain.Entities;
using Webshop.Infrastructure.Persistence;

namespace Webshop.Infrastructure.Seeders;
internal class VatsSeeder(WebshopDbContext dbContext) : IVatsSeeder
{
    public async Task Seed()
    {
        if (await dbContext.Database.CanConnectAsync())
        {
            if (!dbContext.Vats.Any())
            {
                var vats = GetVats();
                dbContext.Vats.AddRange(vats);
                await dbContext.SaveChangesAsync();
            }
        }
    }

    private IEnumerable<Vat> GetVats()
    {
        List<Vat> vats =
        [
            new()
            {
                CODE = "A",
                Name = "5%",
                Value = 5,
            },
            new()
            {
                CODE = "B",
                Name = "18%",
                Value = 18,
            },
            new()
            {
                CODE = "C",
                Name = "27%",
                Value = 27,
            },
            new()
            {
                CODE = "D",
                Name = "AJT",
                Value = 0,
            },
            new()
            {
                CODE = "E",
                Name = "TAM",
                Value = 0,
            },
        ];
        return vats;
    }
}
