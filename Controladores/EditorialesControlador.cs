using Sistema_Biblioteca.Data;
using Sistema_Biblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace Sistema_Biblioteca.Controladores
{
    public class EditorialesControlador
    {
        public static List<EditorialesModelo> GetAll()
        {
            using var context = new LibraryContext();
            return context.Editoriales.ToList();
        }

        public static void Create(EditorialesModelo creareditorial)
        {
            using var context = new LibraryContext();
            context.Editoriales.Add(creareditorial);
            context.SaveChanges();
        }
    }
}
