using Webshop.Domain.Constants;
using Webshop.Domain.Entities;
using Webshop.Infrastructure.Persistence;

namespace Webshop.Infrastructure.Seeders;
internal class ItemSeeder(WebshopDbContext dbContext) : ISeeder
{
    public async Task Seed()
    {
        if (await dbContext.Database.CanConnectAsync())
        {
            if (!dbContext.Items.Any())
            {
                var items = GetItems();
                dbContext.Items.AddRange(items);
                await dbContext.SaveChangesAsync();
            }
        }
    }

    private IEnumerable<Item> GetItems()
    {
        List<Item> roles =
        [
           new(){
               Name = "TestItem1",
               Description = "Description for TestItem1",
               GrossPrice = 1200,
               Currency = CurrencyEnum.HUF.ToString(),
               UnitAmount = 1,
               UnitOfMeasurement = UnitOfMeasurementEnum.pcs.ToString(),
               VatId = 3,
           },
           new(){
               Name = "TestItem2",
               Description = "Description for TestItem2",
               GrossPrice = 2500,
               Currency = CurrencyEnum.HUF.ToString(),
               UnitAmount = 1,
               UnitOfMeasurement = UnitOfMeasurementEnum.kg.ToString(),
               VatId = 3,
           },
           new(){
               Name = "TestItem3",
               Description = "Description for TestItem3",
               GrossPrice = 0,
               Currency = CurrencyEnum.HUF.ToString(),
               UnitAmount = 1,
               UnitOfMeasurement = UnitOfMeasurementEnum.pcs.ToString(),
               VatId = 5,
           },
        ];
        return roles;
    }
}
