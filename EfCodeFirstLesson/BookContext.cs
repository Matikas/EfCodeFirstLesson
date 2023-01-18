using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstLesson
{
    public class BookContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=(localdb)\\mssqllocaldb;Database=BooksDb;Trusted_Connection=True;");
        }
    }
}
