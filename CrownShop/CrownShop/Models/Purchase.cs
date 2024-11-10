using CrownShop.Enums;

namespace CrownShop.Models;

public abstract class Purchase
{
    public int Id { get; set; }
    public int CrownWalletId { get; set; }
    public required CrownWallet CrownWallet { get; set; }
    public int CrownBalanceChange { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public TransactionStatus Status { get; set; }
}
