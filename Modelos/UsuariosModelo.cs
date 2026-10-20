using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Biblioteca.Modelos;

[Table("Usuarios")]
public class UsuariosModelo
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(150)]
    public string Nombre { get; set; } = "";

    [Required]
    [MaxLength(50)]
    public string Usuario { get; set; } = "";

    [Required]
    [MaxLength(255)]
    public string Password { get; set; } = "";

    [Required]
    [MaxLength(20)]
    public string Rol { get; set; } = "normal";

    public byte[]? FotoPerfil { get; set; }
}
