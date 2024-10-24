using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CrownShop.Models;

public class ApplicationUser : IdentityUser<int>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    [DataType(DataType.Date)]
    public DateTime Birthday { get; set; }
}
