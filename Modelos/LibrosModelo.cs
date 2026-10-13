using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Biblioteca.Modelos;

public class LibrosModelo
{
    [Key]
    public int id_libros { get; set; }
    public string titulo { get; set; } = "";
    public int? anio_publicacion { get; set; }
    public string? descripcion { get; set; }
    public int id_editoriales { get; set; }
    public int id_autores { get; set; }
    public int id_categorias { get; set; }
    public byte estado { get; set; }
    public DateTime fecha_registro { get; set; }
}
