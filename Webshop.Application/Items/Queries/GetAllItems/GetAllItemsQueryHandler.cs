using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Webshop.Application.Items.Dtos;
using Webshop.Domain.Repositories;

namespace Webshop.Application.Items.Queries.GetAllItems;
internal class GetAllItemsQueryHandler(ILogger<GetAllItemsQueryHandler> logger,
    IMapper mapper,
    IItemsRepository itemsRepository) : IRequestHandler<GetAllItemsQuery, IEnumerable<ItemDto>>
{
    public async Task<IEnumerable<ItemDto>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Getting all items.");
        var items = await itemsRepository.GetAllAsync();


        var itemsDtos = mapper.Map<IEnumerable<ItemDto>>(items);

        return itemsDtos!;
    }
}