using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SWSTechnologies1.Models
{
    public class TestimonyModel
    { 
        public TestimonyModel()
        {
            DatePublished = DateTime.Now;
        }

        public int Id { get; set; }
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Enter your full name.")]
        [Required(ErrorMessage = "Please enter your full name.")]
        public string Name { get; set; }
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Enter your company name.")]
        [Required(ErrorMessage = "Please enter your company name.")]
        public string Company { get; set; }
        [Required(ErrorMessage ="Please enter your experience.")]
        public string Message { get; set; }
        public DateTime DatePublished { get; set; }
        public bool Publish { get; set; }
    }
}
