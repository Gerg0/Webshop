namespace Webshop.Application.Vats.Dtos;
public class VatDto
{
    public int Id { get; set; }
    public string CODE { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal Value { get; set; }
}
