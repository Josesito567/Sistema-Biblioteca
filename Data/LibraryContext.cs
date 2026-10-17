using Microsoft.EntityFrameworkCore;
using Sistema_Biblioteca.Modelos;

namespace Sistema_Biblioteca.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<EditorialesModelo> Editoriales { get; set; }
        public DbSet<CategoriasModelo> Categorias { get; set; }
        public DbSet<AutoresModelo> Autores { get; set; }
        public DbSet<LibrosModelo> Libros { get; set; }
        public DbSet<CatalogoLibrosModelo> CatalogoLibros { get; set; }
        public DbSet<PrestamosModelo> Prestamos { get; set; }

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