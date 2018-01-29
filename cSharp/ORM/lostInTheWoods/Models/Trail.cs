using System.ComponentModel.DataAnnotations;
namespace lostInTheWoods.Models
{
    public abstract class BaseEntity {}
    public class Trail : BaseEntity
    {
        [Key]
        public int id{get;set;}
 
        [Required]
        [MinLength(1)]
        public string name { get; set; }
 
        [Required]
        [MinLength(5, ErrorMessage = "Description must be over 5 charachters")]
        public string description { get; set; }
 
        [Required(ErrorMessage = "Trail length field is required")]
        public float? trailLength { get; set; }

        [Required(ErrorMessage = "Elevation change field is required")]
        public int? elevationChange { get; set; }

        [Required(ErrorMessage = "Latitude field is required")]
        public double? lat{get;set;}

        [Required(ErrorMessage = "Longitude field is required")]
        public double? lon{get;set;}
    }
}