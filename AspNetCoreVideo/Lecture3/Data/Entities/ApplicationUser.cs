using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture3.Data.Entities
{
    public class User : IdentityUser
    {
        public string Location { get; set; }
    }
}
