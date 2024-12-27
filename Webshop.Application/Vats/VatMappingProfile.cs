using AutoMapper;
using Webshop.Application.Vats.Dtos;
using Webshop.Domain.Entities;

namespace Webshop.Application.Vats;
public class VatMappingProfile : Profile
{
    public VatMappingProfile()
    {
        CreateMap<Vat, VatDto>();
    }
}
