using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibShopper4.Models
{
    public class Product
    {
        [Key]
        public int SkinId { get; set; }

        public string? Weapon { get; set; }
        public string? Skin { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public string? Category { get; set; }
        public string? Image { get; set; }
    }
}
