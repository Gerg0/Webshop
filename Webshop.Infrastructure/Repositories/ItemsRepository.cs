using Microsoft.EntityFrameworkCore;
using Webshop.Domain.Entities;
using Webshop.Domain.Repositories;
using Webshop.Infrastructure.Persistence;

namespace Webshop.Infrastructure.Repositories;
internal class ItemsRepository(WebshopDbContext dbContext) : IItemsRepository
{

    public async Task<IEnumerable<Item>> GetAllAsync()
    {
        var items = await dbContext.Items.Include(x => x.Vat).ToListAsync();
        return items;
    }


    public async Task<Item?> GetByIdAsync(int id)
    {
        var items = await dbContext.Items
            .Include(x => x.Vat)
            .FirstOrDefaultAsync(x => x.Id == id);
        return items;
    }

    public Task SaveChanges() => dbContext.SaveChangesAsync();
}
