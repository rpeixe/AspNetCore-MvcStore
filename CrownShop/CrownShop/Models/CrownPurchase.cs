using CrownShop.Enums;

namespace CrownShop.Models;

public abstract class CrownPurchase : Purchase
{
    public PaymentProvider PaymentProvider { get; set; }
    public decimal Cost { get; set; }
}
