using MediatR;
using Webshop.Application.Items.Dtos;

namespace Webshop.Application.Items.Queries.GetAllItems;
public class GetAllItemsQuery : IRequest<IEnumerable<ItemDto>>
{
}
