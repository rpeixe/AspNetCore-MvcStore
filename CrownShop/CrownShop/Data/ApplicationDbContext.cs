using CrownShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrownShop.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>(options)
{
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<CrownInventory> CrownInventories { get; set; }
    public DbSet<CrownWallet> CrownWallets { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<InventoryItem> InventoryItems { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Membership> Memberships { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<RelatedItem> RelatedItems { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<StoreEntry> StoreEntrys { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Item>()
            .HasDiscriminator<string>("ItemType")
            .HasValue<AccountItem>("AccountItem")
            .HasValue<InGameItem>("InGameItem");
        
        builder.Entity<Purchase>()
            .HasDiscriminator<string>("PurchaseType")
            .HasValue<CrownPurchase>("CrownPurchase")
            .HasValue<ItemPurchase>("ItemPurchase")
            .HasValue<Subscription>("Subscription");
    }
}
