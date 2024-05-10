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

    }
}
