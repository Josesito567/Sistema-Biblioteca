using System.Collections.Generic;
using System.Linq;
using Sistema_Biblioteca.Data;
using Sistema_Biblioteca.Modelos;

namespace Sistema_Biblioteca.Controladores;

public static class CategoriasControlador
{
    public static List<CategoriasModelo> GetAll()
    {
        using var context = new LibraryContext();
        return context.Categorias.ToList();
    }

    //Crear una nueva categoria
    public static void Create(CategoriasModelo categoria)
    {
        using var context = new LibraryContext();
        context.Categorias.Add(categoria);
        context.SaveChanges();
    }
}
