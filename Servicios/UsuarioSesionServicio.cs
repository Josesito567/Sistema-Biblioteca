using Sistema_Biblioteca.Modelos;

namespace Sistema_Biblioteca.Servicios;

public static class UsuarioSesionServicio
{
    public static UsuarioSesion CrearSesion(string usuario)
    {
        var nombreUsuario = usuario.Trim();
        var rol = nombreUsuario.Equals("admin", StringComparison.OrdinalIgnoreCase)
            ? "admin"
            : "normal";

        return new UsuarioSesion
        {
            Nombre = nombreUsuario,
            Usuario = nombreUsuario,
            Rol = rol,
            FotoPerfil = AvatarImagenServicio.CrearAvatarPredeterminado(nombreUsuario)
        };
    }
}
