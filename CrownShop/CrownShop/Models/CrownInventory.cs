using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrownShop.Models;

public class CrownInventory
{
    [Key, ForeignKey("ApplicationUser")]
    public int Id { get; set; }
    public required ApplicationUser User { get; set; }

    public  ICollection<Item> Items { get; set; } = [];
}
