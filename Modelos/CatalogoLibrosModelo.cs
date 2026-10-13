using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Biblioteca.Modelos;

public class CatalogoLibrosModelo
{
    [Key]
    public int id_catalogolibros { get; set; }
    public int id_libros { get; set; }
    public string codigo_ejemplar { get; set; } = "";
    public string? ubicacion_estante { get; set; }
    public string? numero_edicion { get; set; }
    public byte disponible { get; set; }
    public byte estado { get; set; }
    public DateTime fecha_registro { get; set; }
}
