using Webshop.Domain.Entities;

namespace Webshop.Domain.Repositories;
public interface IItemsRepository
{
    Task<IEnumerable<Item>> GetAllAsync();
    Task<Item?> GetByIdAsync(int id);

    Task SaveChanges();
}
