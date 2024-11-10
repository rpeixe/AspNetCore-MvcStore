namespace CrownShop.Models;

public class Discount
{
    public int Id { get; set; }
    public int StoreEntryId { get; set; }
    public required StoreEntry StoreEntry { get; set; }
    public int SaleId { get; set; }
    public required Sale Sale { get; set; }
    
    public int PercentageOff { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
