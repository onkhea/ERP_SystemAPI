using ERP_system.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ERP_system.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<SalesOrderLine> OrderLines { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
