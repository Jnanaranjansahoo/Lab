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
    public class Archive
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        [ValidateNever]
        public Client? Client { get; set; }
        public int Count { get; set; }
        public string? ApplicationUserId {  get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser? ApplicationUser { get; set; }
        [Required]
        [Display(Name = "Enter Name")]
        public string? CName { get; set; }
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
        [Required]
        [Display(Name = "Total Price")]
        public double? Total { get; set; }
        public int? OfficerId { get; set; }
        [ForeignKey("OfficerId")]
        [ValidateNever]

        public Officer? Officer { get; set; }
        public string? ImageUrl { get; set; }
    }
}
