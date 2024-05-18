using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models.ViewModels
{
    public class ClientVM
    {
        public Client Client { get; set; }
        public int Count { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? OfficerList { get; set; }
    }
}
