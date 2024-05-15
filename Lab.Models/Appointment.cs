using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Enter Name")]
        public string? CuName { get; set; }
        [Required]
        [Range(1000000000,9999999999,ErrorMessage ="Enter a valid mobile number")]
        [Display(Name = "Mobile No.")]
        public int? CMobile { get; set; }
        [Required]
        [Display(Name = "District")]
        public string? CDist { get; set; }
        [Required]
        [Display(Name = "Post")]
        public string? CPos { get; set; }
        [Required]
        [Display(Name = "Pin Code")]
        public int? CPin { get; set; }
        [Required]
        [Display(Name = "Land Mark")]
        public string? CLandMark { get; set; }
        public int? ClientId { get; set; }
        [ForeignKey("ClientId")]
        [ValidateNever]
        public Client? Client { get; set; }
        public string? ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
