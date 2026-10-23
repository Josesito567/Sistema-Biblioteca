using Sistema_Biblioteca.Data;
using Sistema_Biblioteca.Modelos;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Sistema_Biblioteca.Controladores;

public class EditorialesControlador
{
    public static List<EditorialesModelo> GetAll()
    {
        using var context = LibraryContextFactory.Create();
        return context.Editoriales.AsNoTracking().ToList();
    }

    public static void Create(EditorialesModelo crearEditorial)
    {
        using var context = LibraryContextFactory.Create();
        context.Editoriales.Add(crearEditorial);
        context.SaveChanges();
    }
    /// <summary>
    /// Elimina una editorial. Retorna true si fue exitoso; de lo contrario false y devuelve el mensaje de error.
    /// </summary>
    public static bool Delete(int id, out string mensajeError)
    {
        mensajeError = string.Empty;
        using var context = LibraryContextFactory.Create();

        var editorial = context.Editoriales.Find(id);
        if (editorial == null)
        {
            mensajeError = "La editorial especificada no existe.";
            return false;
        }

        // Any() es más óptimo que Count() > 0 en Entity Framework
        bool tieneLibros = context.Libros.Any(l => l.id_editoriales == id);
        if (tieneLibros)
        {
            mensajeError = $"No se puede eliminar la editorial '{editorial.nombre}' porque tiene libros asociados.";
            return false;
        }

        context.Editoriales.Remove(editorial);
        context.SaveChanges();
        return true;
    }

    public static int CountBookByPublisher(int id)
    {
        using var context = LibraryContextFactory.Create();
        return context.Libros.Count(l => l.id_editoriales == id);
    }
}

