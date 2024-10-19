using System.ComponentModel.DataAnnotations;
using CrownShop.Enums;

namespace CrownShop.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int PriceInCrowns { get; set; }
    public ProductType Type { get; set; }
}
