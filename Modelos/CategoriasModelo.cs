using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Biblioteca.Modelos;

public class CategoriasModelo
{
    [Key]
    public int id_categorias { get; set; }
    public string nombre { get; set; } = "";
    public string? descripcion { get; set; }
    public byte estado { get; set; }
    public DateTime fecha_registro { get; set; }
}
