using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SWSTechnologies1.Models
{
    public class RegisterViewModel
    {
       public int Id { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="You need to give us your email address.")]
        public string Email { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Confirm Email")]
        [Compare("Email", ErrorMessage = "Your emails must match.")]
        public string ConfirmEmail { get; set; }

        
        [Required(ErrorMessage ="You must have a password.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage ="You need to provide a longer password.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]

        [Compare("Password", ErrorMessage ="Your passwords must match.")]
        public string ConfirmPassword { get; set; }
    }
}
