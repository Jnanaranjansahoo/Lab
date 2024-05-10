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

        public string? ApplicaationUserId { get; set; }
        [ForeignKey("ApplicaationUserId")]
        [ValidateNever]
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
