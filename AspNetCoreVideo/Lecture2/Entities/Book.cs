using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Lecture2.Models;

namespace Lecture2.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public Genre Genre { get; set; }
    }

}
