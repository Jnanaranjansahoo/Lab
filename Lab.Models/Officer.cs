using System.ComponentModel.DataAnnotations;

namespace Lab.Models
{
    public class Officer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String? Name { get; set; }
        [Required]
        public int Pnumb { get; set; }
        [Required]
        public String? Address { get; set; }
        [Required]
        public String? City { get; set; }
        [Required]
        public String? Dist { get; set; }
        [Required]
        public int? Pincode { get; set; }
        [Required]
        public int? Aadhar { get; set;}
        [Required]
        public string? Pancard { get; set; }
    }
}
