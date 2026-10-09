using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sistema_Biblioteca.Modelos;
using Sistema_Biblioteca.Data;

namespace Sistema_Biblioteca.Controladores
{
    public class EditorialesControlador
    {
        public static List<EditorialesModelo> GetAll()
        {
            using var context = new LibraryContext();
            return context.Editoriales.ToList();
        }
    }
}
