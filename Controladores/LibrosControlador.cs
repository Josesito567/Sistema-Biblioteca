using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Sistema_Biblioteca.Data;
using Sistema_Biblioteca.Modelos;

namespace Sistema_Biblioteca.Controladores;

public static class LibrosControlador
{
    public static List<LibrosModelo> GetAll()
    {
        using var context = LibraryContextFactory.Create();
        return context.Libros.AsNoTracking().ToList();
    }
}
