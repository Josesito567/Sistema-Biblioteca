using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Biblioteca.Modelos;

public class PrestamosModelo
{
    [Key]
    public int id_prestamos { get; set; }
    public int id_catalogolibros { get; set; }
    public string nombre_solicitante { get; set; } = "";
    public string? identificacion { get; set; }
    public string? telefono { get; set; }
    public DateTime fecha_prestamo { get; set; }
    public DateTime fecha_devolucion_esperada { get; set; }
    public DateTime? fecha_devolucion_real { get; set; }
    public string? observaciones { get; set; }
    public byte estado { get; set; }
    public DateTime fecha_registro { get; set; }
}
