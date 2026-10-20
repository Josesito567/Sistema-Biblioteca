using Sistema_Biblioteca.Data;
using Sistema_Biblioteca.Modelos;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Sistema_Biblioteca.Controladores;

public static class EditorialesControlador
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
}
