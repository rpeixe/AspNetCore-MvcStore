namespace CrownShop.Models;

public class Subscription : Purchase
{
    public int MembershipId { get; set; }
    public virtual required Membership Membership { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive { get; set; }
}
