namespace Webshop.Domain.Entities;
public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal GrossPrice { get; set; }
    public Vat Vat { get; set; } = new Vat();
    public int VatId { get; set; }
}
