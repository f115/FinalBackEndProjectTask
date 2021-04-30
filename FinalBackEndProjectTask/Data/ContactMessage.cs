using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalBackEndProjectTask.Data
{
    public class ContactMessage
    {
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 2)]
        
        public string Name { get; set; }

        [Required(ErrorMessage = "Message isn't given")]
        [StringLength(maximumLength: 1000, MinimumLength = 2)]
        public string text { get; set; }

        [Required(ErrorMessage = "Email isn't given")]
        [EmailAddress(ErrorMessage = "Your Email isn't valid")]
        public string Email { get; set; }
        [Required]
        public string Budgetlvl { get; set; }

        [Required(ErrorMessage = "Phone isn't given")]
        
        public int Phone { get; set; }

        public int Id { get; set; }
        

        



    }
}