using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projeto.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options){}

        // Definindo os DbSets para as entidades que vão ser persistidas no banco de dados.
        public DbSet<Alert> Alert { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Catalog> Catalog { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Librarian> Librarian { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Student> Student { get; set; }
        
    }
}