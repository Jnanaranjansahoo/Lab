using System.ComponentModel.DataAnnotations;

namespace Lab.Models
{
    public class Officer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Enter Name")]
        public string? Name { get; set; }

        [Display(Name = "Enter Name")]
        public int? Totalclient { get; set; }

        [Required]
        [Display(Name = "Mobile No.")]
       
        public int? Mobile { get; set; }
        
        [Required]
        [Display(Name = "District")]
        public string? Dist { get; set; }
        [Required]
        [Display(Name = "Post")]
        public string? Pos { get; set; }
        [Required]
        [Display(Name = "Pin Code")]
        public int? Pin { get; set; }
        [Required]
        [Display(Name = "Land Mark")]
        public string? LandMark { get; set; }
    }
}
