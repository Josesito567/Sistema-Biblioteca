using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Sistema_Biblioteca.Data;
using Sistema_Biblioteca.Modelos;

namespace Sistema_Biblioteca.Controladores;

public static class AutoresControlador
{
    public static List<AutoresModelo> GetAll()
    {
        using var context = LibraryContextFactory.Create();
        return context.Autores.AsNoTracking().ToList();
    }

    public static bool ExisteNombre(string nombre, int idExcluir = 0)
    {
        using var context = LibraryContextFactory.Create();
        return context.Autores.AsNoTracking().Any(autor =>
            autor.id_autores != idExcluir &&
            autor.nombre == nombre);
    }

    public static void Create(AutoresModelo nuevoAutor)
    {
        using var context = LibraryContextFactory.Create();
        context.Autores.Add(nuevoAutor);
        context.SaveChanges();
    }

    public static void Update(AutoresModelo autor)
    {
        using var context = LibraryContextFactory.Create();
        context.Autores.Update(autor);
        context.SaveChanges();
    }

    public static bool Delete(int id, out string mensajeError)
    {
        mensajeError = string.Empty;
        using var context = LibraryContextFactory.Create();

        var autor = context.Autores.Find(id);
        if (autor == null)
        {
            mensajeError = "El autor especificado no existe.";
            return false;
        }

        // Verifica si el autor tiene libros asociados
        bool tieneLibros = context.Libros.Any(l => l.id_autores == id);
        if (tieneLibros)
        {
            mensajeError = $"No se puede eliminar el autor '{autor.nombre}' porque tiene libros asociados.";
            return false;
        }

        context.Autores.Remove(autor);
        context.SaveChanges();
        return true;
    }
}
