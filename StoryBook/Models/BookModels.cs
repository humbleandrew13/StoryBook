using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoryBook.Models
{
    public class BookModels
    {
        [Key]
        public int BookID { get; set; }

        public string BookTitle { get; set; }
        public int BookPage { get; set; }

    }
}