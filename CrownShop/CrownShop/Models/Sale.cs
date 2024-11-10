namespace CrownShop.Models;

public class Sale
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public ICollection<Discount> Discounts { get; set; } = [];
}
