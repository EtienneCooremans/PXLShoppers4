using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PXLProShopper04.Models
{
    public class Skins
    {
        [Key]
        public int SkinId { get; set; }

        public string? Title { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Price { get; set; }
        public int? Stock { get; set; }
        public string? Category { get; set; }

    }
}
