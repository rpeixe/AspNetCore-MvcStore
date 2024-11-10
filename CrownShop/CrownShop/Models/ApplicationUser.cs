using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CrownShop.Models;

public class ApplicationUser : IdentityUser<int>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    [DataType(DataType.Date)]
    public DateTime Birthday { get; set; }

    public virtual required CrownWallet CrownWallet { get; set; }
    public virtual required CrownInventory CrownInventory { get; set; }
}
