using CrownShop.Enums;

namespace CrownShop.Models;

public class RelatedItem
{
    public int Id { get; set; }
    public int StoreEntryId { get; set; }
    public virtual required StoreEntry StoreEntry { get; set; }
    public int ItemId { get; set; }
    public virtual required Item Item { get; set; }
    public RelatedItemType Type { get; set; }
    public int Quantity { get; set; }
}