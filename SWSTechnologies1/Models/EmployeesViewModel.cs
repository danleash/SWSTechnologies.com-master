using Microsoft.AspNetCore.Identity;
using SWSTechnologies1.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWSTechnologies1.Models
{
    public class EmployeesViewModel
    {
        public IEnumerable<ApplicationUser> Accounts { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public EmployeesViewModel() {
            Accounts = new List<ApplicationUser>();
            ApplicationUser = new ApplicationUser();
        }

    }
}
