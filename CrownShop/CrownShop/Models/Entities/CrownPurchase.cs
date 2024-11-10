using CrownShop.Enums;

namespace CrownShop.Models.Entities;

public class CrownPurchase : Purchase
{
    public PaymentProvider PaymentProvider { get; set; }
    public decimal Cost { get; set; }
}
