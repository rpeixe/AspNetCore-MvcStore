namespace CrownShop.Models;

public class ItemPurchase : Purchase
{
    public int StoreEntryId { get; set; }
    public virtual required StoreEntry StoreEntry { get; set; }
    public int Quantity { get; set; }
}
