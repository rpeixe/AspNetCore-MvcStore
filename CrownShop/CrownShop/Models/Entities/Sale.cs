namespace CrownShop.Models.Entities;

public class Sale
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public virtual ICollection<Discount> Discounts { get; set; } = [];
}
