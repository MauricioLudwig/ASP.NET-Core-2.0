using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture3.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Username is required.....")]
        public string UserName { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string Password { get; set; }
    }
}
