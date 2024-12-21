namespace Webshop.Domain.Entities;
public class Vat
{
    public int Id { get; set; }
    public string CODE { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal Value { get; set; }
    public List<Item> Items { get; set; } = new List<Item>();
}
