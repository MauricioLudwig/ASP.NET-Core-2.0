using Lecture2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture2.ViewModels
{
    public class NewBookVM
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Pages { get; set; }
        public Genre Genre { get; set; }
    }
}
