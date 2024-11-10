using CrownShop.Enums;

namespace CrownShop.Models.Entities;

public abstract class Purchase
{
    public int Id { get; set; }
    public int CrownWalletId { get; set; }
    public virtual required CrownWallet CrownWallet { get; set; }
    public int CrownBalanceChange { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public TransactionStatus Status { get; set; }
}
