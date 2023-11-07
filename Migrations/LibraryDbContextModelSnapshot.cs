﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto.Models;

#nullable disable

namespace Projeto.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Projeto.Models.Alert", b =>
                {
                    b.Property<int>("AlertId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bookname")
                        .HasColumnType("longtext");

                    b.Property<int>("Fine")
                        .HasColumnType("int");

                    b.Property<DateTime>("Issuedate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LibrarianId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Returndate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("AlertId");

                    b.HasIndex("LibrarianId");

                    b.ToTable("Alert");
                });

            modelBuilder.Entity("Projeto.Models.Books", b =>
                {
                    b.Property<int>("BooksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Authorname")
                        .HasColumnType("longtext");

                    b.Property<int?>("CatalogId")
                        .HasColumnType("int");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("Noofbooks")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("BooksId");

                    b.HasIndex("CatalogId");

                    b.HasIndex("MemberId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Projeto.Models.Catalog", b =>
                {
                    b.Property<int>("CatalogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Authorname")
                        .HasColumnType("longtext");

                    b.Property<int>("Noofcopies")
                        .HasColumnType("int");

                    b.HasKey("CatalogId");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("Projeto.Models.Librarian", b =>
                {
                    b.Property<int>("LibrarianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<int>("Mobileno")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("LibrarianId");

                    b.ToTable("Librarian");
                });

            modelBuilder.Entity("Projeto.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Maddress")
                        .HasColumnType("longtext");

                    b.Property<string>("Mname")
                        .HasColumnType("longtext");

                    b.Property<int>("Mno")
                        .HasColumnType("int");

                    b.HasKey("MemberId");

                    b.ToTable("Member");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Member");
                });

            modelBuilder.Entity("Projeto.Models.Faculty", b =>
                {
                    b.HasBaseType("Projeto.Models.Member");

                    b.Property<string>("Facultycoll")
                        .HasColumnType("longtext");

                    b.Property<string>("Facultycourse")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Faculty");
                });

            modelBuilder.Entity("Projeto.Models.Student", b =>
                {
                    b.HasBaseType("Projeto.Models.Member");

                    b.Property<string>("Studentclass")
                        .HasColumnType("longtext");

                    b.Property<string>("Studentcoll")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Projeto.Models.Alert", b =>
                {
                    b.HasOne("Projeto.Models.Librarian", null)
                        .WithMany("Alerts")
                        .HasForeignKey("LibrarianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projeto.Models.Books", b =>
                {
                    b.HasOne("Projeto.Models.Catalog", null)
                        .WithMany("Books")
                        .HasForeignKey("CatalogId");

                    b.HasOne("Projeto.Models.Member", null)
                        .WithMany("Books")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("Projeto.Models.Catalog", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Projeto.Models.Librarian", b =>
                {
                    b.Navigation("Alerts");
                });

            modelBuilder.Entity("Projeto.Models.Member", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
