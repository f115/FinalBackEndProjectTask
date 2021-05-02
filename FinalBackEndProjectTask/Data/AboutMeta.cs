using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace FinalBackEndProjectTask.Data
{
    public class AboutMeta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Message isn't given")]
        [StringLength(maximumLength: 1000, MinimumLength = 2)]
        public string Text { get; set; }

        public int Procent { get; set; }

        public string Diagramme { get; set; }
        public string ImagePath { get; set; }
    }
}