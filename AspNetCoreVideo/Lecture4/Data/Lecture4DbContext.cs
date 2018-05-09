using Lecture4.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture4.Data
{
    public class Lecture4DbContext : DbContext
    {

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }

        public Lecture4DbContext(DbContextOptions<Lecture4DbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AuthorBook>().HasKey(o => new { o.AuthorId, o.BookId });

            builder.Entity<AuthorBook>()
                .HasOne(o => o.Author)
                .WithMany(o => o.AuthorBooks)
                .HasForeignKey(o => o.AuthorId);

            builder.Entity<AuthorBook>()
    .HasOne(o => o.Book)
    .WithMany(o => o.AuthorBooks)
    .HasForeignKey(o => o.BookId);
        }

    }
}
