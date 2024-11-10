using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrownShop.Models;

public class CrownWallet
{
    [Key, ForeignKey("ApplicationUser")]
    public int Id { get; set; }
    public required ApplicationUser User { get; set; }

    public int CrownBalance { get; set; }
    public ICollection<Purchase> Purchases { get; set; } = [];

    [Timestamp]
    public byte[]? Version { get; set; }
}
