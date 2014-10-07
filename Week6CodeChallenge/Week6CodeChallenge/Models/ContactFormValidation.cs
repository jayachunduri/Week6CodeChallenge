using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Week6CodeChallenge.Models
{
  
    public class ContactFormValidation
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ProjectDescription { get; set; }
        [Required]
        public string Message { get; set; }
    }
    
    [MetadataType(typeof(ContactFormValidation))]
    public partial class ContactForm
    {
      
    }
}