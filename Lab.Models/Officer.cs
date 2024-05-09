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

        [Display(Name = "Costumor No.")]
        public int? Cost { get; set; }
    }
}
