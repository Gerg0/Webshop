using MediatR;
using Microsoft.AspNetCore.Mvc;
using Webshop.Application.Items.Dtos;
using Webshop.Application.Items.Queries.GetAllItems;

namespace Webshop.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ItemsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ItemDto>>> GetAll([FromQuery] GetAllItemsQuery searchPhrase)
    {
        var result = await mediator.Send(new GetAllItemsQuery());
        return Ok(result);
    }
}
