﻿// <auto-generated />
using Lecture2.Data;
using Lecture2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Lecture2.Migrations
{
    [DbContext(typeof(BooksDbContext))]
    partial class BooksDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lecture2.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("Unknown");

                    b.Property<int>("Genre");

                    b.Property<int>("Pages");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Lecture2.Entities.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Library");
                });
#pragma warning restore 612, 618
        }
    }
}
