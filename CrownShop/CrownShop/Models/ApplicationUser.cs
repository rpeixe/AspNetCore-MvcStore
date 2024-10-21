using Microsoft.AspNetCore.Identity;

namespace CrownShop.Models;

public class ApplicationUser : IdentityUser
{
    public int CrownBalance { get; set; }
}
