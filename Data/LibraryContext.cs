using Microsoft.EntityFrameworkCore;
using Sistema_Biblioteca.Modelos;

namespace Sistema_Biblioteca.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<EditorialesModelo> Editoriales { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=14-LAB1PC3\TECHNOTEL;
                  Database=sistema_biblioteca;
                  Trusted_Connection=True;
                  TrustServerCertificate=True;");
        }
    }
}