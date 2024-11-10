using System.ComponentModel.DataAnnotations.Schema;
using CrownShop.Enums;

namespace CrownShop.Models.Entities;

public abstract class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ItemCategory Category { get; set; }

    public virtual ICollection<InventoryItem> Owners { get; set; } = [];

    public virtual ICollection<RelatedItem> RelatedStoreEntries { get; set; } = [];

    [NotMapped]
    public virtual IEnumerable<RelatedItem> RequiredFor =>
        RelatedStoreEntries.Where(r => r.Type == RelatedItemType.Prerequisite);

    [NotMapped]
    public virtual IEnumerable<RelatedItem> IncludedInStoreEntries =>
        RelatedStoreEntries.Where(r => r.Type == RelatedItemType.Included);
}
