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
}
