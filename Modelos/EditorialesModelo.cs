using System;
using System.Collections.Generic;
using System.Text;
using Sistema_Biblioteca.Data;

namespace Sistema_Biblioteca.Modelos
{
    public class EditorialesModelo
    {
        public int id_editoriales { get; set; }
        public string nombre { get; set; } = "";
        public string direccion { get; set; } = "";
        public string ciudad { get; set; } = "";
        public string telefono { get; set; } = "";
        public string email { get; set; } = "";
        public string estado { get; set; } = "";
        public DateTime fecha_registro { get; set; } = DateTime.Now;
    }
}
