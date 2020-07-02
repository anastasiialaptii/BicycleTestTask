using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Bicycle : BaseEntity
    {
        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string BicycleCategory { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public bool IsRented { get; set; }
    }
}
