using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Book_Library.Models
{
    public class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ApplicationUser Author { get; set; }
    }
}