using Webshop.Application.Vats.Dtos;

namespace Webshop.Application.Items.Dtos;
public class ItemDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal GrossPrice { get; set; }
    public string Currency { get; set; } = string.Empty;
    public decimal UnitAmount { get; set; }
    public string UnitOfMeasurement { get; set; } = string.Empty;
    public VatDto Vat { get; set; } = new();
}
