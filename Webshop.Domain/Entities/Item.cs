namespace Webshop.Domain.Entities;
public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal GrossPrice { get; set; }
    public string Currency { get; set; } = string.Empty;
    public decimal UnitAmount { get; set; }
    public string UnitOfMeasurement { get; set; } = string.Empty;
    public Vat Vat { get; set; } = null!;
    public int VatId { get; set; }
}
