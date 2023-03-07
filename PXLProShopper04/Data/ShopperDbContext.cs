using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PXLProShopper04.Models;

namespace PXLProShopper04.Data
{
    public class ShopperDbContext : IdentityDbContext
    {
        public ShopperDbContext(DbContextOptions<ShopperDbContext> options) : base(options)
        {

        }
        public DbSet<Skins> Skins { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
