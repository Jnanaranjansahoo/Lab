using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        public String? Name { get; set; }
        [Required]
        [Range(1000000000, 9999999999, ErrorMessage = "Enter a valid mobile number")]
        public int Pnumb { get; set; }
        [Required]
        public String? Address { get; set; }
        [Required]
        public String? City { get; set; }
        [Required]
        public String? Dist { get; set; }
        [Required]
        public int? Pincode { get; set; }
        public int? OfficerId { get; set; }
        [ForeignKey("OfficerId")]
        [ValidateNever]
        public Officer? Officer { get; set; }
        [NotMapped]
        public string? Role { get; set; }

    }
}
