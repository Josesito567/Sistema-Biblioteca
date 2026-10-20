using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Sistema_Biblioteca.Data;
using Sistema_Biblioteca.Modelos;

namespace Sistema_Biblioteca.Controladores;

public static class CategoriasControlador
{
    public static List<CategoriasModelo> GetAll()
    {
        using var context = LibraryContextFactory.Create();
        return context.Categorias.AsNoTracking().ToList();
    }

    public static bool ExisteNombre(string nombre, int idExcluir = 0)
    {
        using var context = LibraryContextFactory.Create();
        return context.Categorias.AsNoTracking().Any(categoria =>
            categoria.id_categorias != idExcluir &&
            categoria.nombre == nombre);
    }

    //Crear una nueva categoria
    public static void Create(CategoriasModelo categoria)
    {
        using var context = LibraryContextFactory.Create();
        context.Categorias.Add(categoria);
        context.SaveChanges();
    }
}
