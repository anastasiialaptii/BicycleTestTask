using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BicycleTaskApi.Models
{
    public class Bicycle
    {
        [Key]
        public int Id { get; set; }

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
