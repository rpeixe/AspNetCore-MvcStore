using CrownShop.Enums;

namespace CrownShop.Models;

public class StoreEntry
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int PriceInCrowns { get; set; }
    public virtual ItemCategory Category { get; set; }
    public int MaxQuantity { get; set; }

    public virtual ICollection<Discount> Discounts { get; set; } = [];
    public virtual ICollection<ItemPurchase> Purchases { get; set; } = [];

    public virtual ICollection<RelatedItem> RelatedItems { get; set; } = [];
    public IEnumerable<RelatedItem> Prerequisites =>
        RelatedItems.Where(r => r.Type == RelatedItemType.Prerequisite);
    public IEnumerable<RelatedItem> IncludedItems =>
        RelatedItems.Where(r => r.Type == RelatedItemType.Included);
}