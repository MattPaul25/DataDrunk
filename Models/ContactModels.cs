using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataDrunk.Models
{
    public class ContactModels
    {
        
        public int Id { get; set; }

        [Required]
        [Display(Name="Name")]
        public string FullName { get; set; }

        [Required]
        [Display(Name="Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name="Your Message:")]
        public string Message { get; set; }
    }
}