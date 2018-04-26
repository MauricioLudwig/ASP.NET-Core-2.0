using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lecture2.Entities;

namespace Lecture2.Data
{
    public class BooksDbContext : DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Library { get; set; }

        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>()
                .Property(o => o.Author)
                .HasDefaultValue("Unknown");
        }

    }
}
