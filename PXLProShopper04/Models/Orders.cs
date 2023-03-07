using System.ComponentModel.DataAnnotations;

namespace PXLProShopper04.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }

        public int? LoginId { get; set; }
        public int? SkinId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? Amount { get; set; }
    }
}
