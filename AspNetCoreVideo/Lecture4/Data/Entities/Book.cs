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

        //public int BookId { get; set; }
        //public int BOOKID { get; set; }
        //public int ID { get; set; }
        //public int id { get; set; }

        public int Id { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public ICollection<AuthorBook> AuthorBooks { get; set; }
    }
}
