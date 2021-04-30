using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalBackEndProjectTask.Data
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Text { get; set; }

        public DateTime WrittenTime { get; set; }

        public string ImagePath { get; set; }


    }
}