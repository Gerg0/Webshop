using AutoMapper;
using Webshop.Application.Items.Dtos;
using Webshop.Domain.Entities;

namespace Webshop.Application.Items;
public class ItemMappingProfile : Profile
{
    public ItemMappingProfile()
    {
        CreateMap<Item, ItemDto>()
            .ForMember(d => d.Vat, opt => opt.MapFrom(src => src.Vat));
    }
}
