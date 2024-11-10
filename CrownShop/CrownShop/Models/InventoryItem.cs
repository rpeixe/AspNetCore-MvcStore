using CrownShop.Enums;

namespace CrownShop.Models;

public class InventoryItem
{
    public int Id { get; set; }
    public int CrownInventoryId { get; set; }
    public required CrownInventory CrownInventory { get; set; }
    public int ItemId { get; set; }
    public required Item Item { get; set; }
    public int Quantity { get; set; }
}
