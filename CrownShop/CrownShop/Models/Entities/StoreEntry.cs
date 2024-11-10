using System.ComponentModel.DataAnnotations.Schema;
using CrownShop.Enums;

namespace CrownShop.Models.Entities;

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

    [NotMapped]
    public IEnumerable<RelatedItem> Prerequisites =>
        RelatedItems.Where(r => r.Type == RelatedItemType.Prerequisite);

    [NotMapped]
    public IEnumerable<RelatedItem> IncludedItems =>
        RelatedItems.Where(r => r.Type == RelatedItemType.Included);
}