using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace FinalBackEndProjectTask.Data
{
    public class Footer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Message isn't given")]
        [StringLength(maximumLength: 1000, MinimumLength = 2)]
        public string text { get; set; }


    }
}