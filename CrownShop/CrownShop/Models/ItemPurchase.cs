namespace CrownShop.Models;

public abstract class ItemPurchase : Purchase
{
    public int StoreEntryId { get; set; }
    public required StoreEntry StoreEntry { get; set; }
    public int Quantity { get; set; }
}
