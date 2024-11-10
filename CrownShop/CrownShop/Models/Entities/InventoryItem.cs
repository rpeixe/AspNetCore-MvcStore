using CrownShop.Enums;

namespace CrownShop.Models.Entities;

public class InventoryItem
{
    public int Id { get; set; }
    public int CrownInventoryId { get; set; }
    public virtual required CrownInventory CrownInventory { get; set; }
    public int ItemId { get; set; }
    public virtual required Item Item { get; set; }
    public int Quantity { get; set; }
}
