namespace CrownShop.Models.Entities;

public class Discount
{
    public int Id { get; set; }
    public int StoreEntryId { get; set; }
    public virtual required StoreEntry StoreEntry { get; set; }
    public int SaleId { get; set; }
    public virtual required Sale Sale { get; set; }

    public int PercentageOff { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
