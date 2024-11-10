using CrownShop.Enums;

namespace CrownShop.Models;

public abstract class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ItemCategory Category { get; set; }

    public ICollection<InventoryItem> Owners { get; set; } = [];

    public ICollection<RelatedItem> RelatedStoreEntries { get; set; } = [];
    public IEnumerable<RelatedItem> RequiredFor =>
        RelatedStoreEntries.Where(r => r.Type == RelatedItemType.Prerequisite);
    public IEnumerable<RelatedItem> IncludedInStoreEntries =>
        RelatedStoreEntries.Where(r => r.Type == RelatedItemType.Included);
}
