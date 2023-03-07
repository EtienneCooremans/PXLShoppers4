using System.ComponentModel.DataAnnotations;

namespace PXLProShopper04.Models
{
    public class Skins
    {
        [Key]
        public int SkinId { get; set; }

        public string? Title { get; set; }
        public decimal? Price { get; set; }
        public int? Stock { get; set; }
        public string? Category { get; set; }

    }
}
