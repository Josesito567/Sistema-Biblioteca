using System.Collections.Generic;
using System.Linq;
using Sistema_Biblioteca.Data;
using Sistema_Biblioteca.Modelos;

namespace Sistema_Biblioteca.Controladores;

public static class AutoresControlador
{
    public static List<AutoresModelo> GetAll()
    {
        using var context = new LibraryContext();
        return context.Autores.ToList();
    }

    public static void Create(AutoresModelo nuevoAutor)
    {
        using var context = new LibraryContext();
        context.Autores.Add(nuevoAutor);
        context.SaveChanges();
    }

    public static void Update(AutoresModelo autor)
    {
        using var context = new LibraryContext();
        context.Autores.Update(autor);
        context.SaveChanges();
    }
}
