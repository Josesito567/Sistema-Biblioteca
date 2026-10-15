using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Biblioteca.Modelos;

public class AutoresModelo
{
    [Key]
    public int id_autores { get; set; }
    public string nombre { get; set; } = "";
    public string? nacionalidad { get; set; }
    public string? telefono { get; set; }
    public string? email { get; set; }
    public byte estado { get; set; }
    public DateTime fecha_registro { get; set; }
}