using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture4.Data.Entities
{
    public class Book
    {
        // Naming Convention
        // Case insensitive
        // Entity class name +(or) Id are valid primary key names

        //public int BookId { get; set; }
        //public int ID { get; set; }
        //public int id { get; set; }

        public int Id { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
    }
}
