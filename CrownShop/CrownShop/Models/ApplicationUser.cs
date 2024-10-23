using Microsoft.AspNetCore.Identity;

namespace CrownShop.Models;

public class ApplicationUser : IdentityUser<int>
{
    public int CrownBalance { get; set; }
}
