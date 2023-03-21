using ClassLibShopper4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibShopper4
{
    public class ShopperDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
