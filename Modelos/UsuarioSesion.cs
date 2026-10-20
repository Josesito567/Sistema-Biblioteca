namespace Sistema_Biblioteca.Modelos;

public sealed class UsuarioSesion
{
    public int Id { get; init; }
    public string Nombre { get; init; } = "";
    public string Usuario { get; init; } = "";
    public string Rol { get; init; } = "normal";
    public byte[]? FotoPerfil { get; init; }
}
