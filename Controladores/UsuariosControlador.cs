using Microsoft.EntityFrameworkCore;
using Sistema_Biblioteca.Data;
using Sistema_Biblioteca.Modelos;
using Sistema_Biblioteca.Servicios;

namespace Sistema_Biblioteca.Controladores;

public static class UsuariosControlador
{
    private static readonly string[] RolesPermitidos = ["admin", "normal"];

    public static List<UsuariosModelo> ObtenerTodos()
    {
        using var context = LibraryContextFactory.Create();
        return context.Usuarios
            .AsNoTracking()
            .OrderBy(usuario => usuario.Nombre)
            .ToList();
    }

    public static UsuarioSesion? Autenticar(string usuario, string password)
    {
        if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrEmpty(password))
        {
            return null;
        }

        using var context = LibraryContextFactory.Create();
        var usuarioDb = context.Usuarios
            .AsNoTracking()
            .SingleOrDefault(registro => registro.Usuario == usuario.Trim());

        if (usuarioDb is null || !PasswordServicio.Verificar(password, usuarioDb.Password))
        {
            return null;
        }

        return CrearSesion(usuarioDb);
    }

    public static UsuarioSesion Registrar(string nombre, string usuario, string password)
    {
        var nombreLimpio = nombre.Trim();
        var usuarioLimpio = usuario.Trim();

        ValidarTexto(nombreLimpio, "El nombre es obligatorio.", 150);
        ValidarTexto(usuarioLimpio, "El usuario es obligatorio.", 50);
        ValidarTexto(password, "La contraseña es obligatoria.", 100);

        using var context = LibraryContextFactory.Create();
        if (context.Usuarios.Any(registro => registro.Usuario == usuarioLimpio))
        {
            throw new InvalidOperationException("Ya existe un usuario con ese nombre de usuario.");
        }

        var usuarioNuevo = new UsuariosModelo
        {
            Nombre = nombreLimpio,
            Usuario = usuarioLimpio,
            Password = PasswordServicio.CrearHash(password),
            Rol = "normal",
            FotoPerfil = AvatarImagenServicio.CrearAvatarPredeterminado(usuarioLimpio)
        };

        context.Usuarios.Add(usuarioNuevo);
        context.SaveChanges();
        return CrearSesion(usuarioNuevo);
    }

    public static void CambiarRol(int idUsuario, string rol)
    {
        var rolNormalizado = rol.Trim().ToLowerInvariant();
        if (!RolesPermitidos.Contains(rolNormalizado, StringComparer.Ordinal))
        {
            throw new ArgumentException("El rol indicado no es válido.", nameof(rol));
        }

        using var context = LibraryContextFactory.Create();
        var usuario = context.Usuarios.SingleOrDefault(registro => registro.Id == idUsuario)
            ?? throw new InvalidOperationException("El usuario no existe.");

        if (usuario.Rol.Equals("admin", StringComparison.OrdinalIgnoreCase) && rolNormalizado == "normal")
        {
            var administradores = context.Usuarios.Count(registro => registro.Rol == "admin");
            if (administradores <= 1)
            {
                throw new InvalidOperationException("No se puede quitar el último administrador del sistema.");
            }
        }

        usuario.Rol = rolNormalizado;
        context.SaveChanges();
    }

    private static UsuarioSesion CrearSesion(UsuariosModelo usuario)
    {
        return new UsuarioSesion
        {
            Id = usuario.Id,
            Nombre = usuario.Nombre,
            Usuario = usuario.Usuario,
            Rol = usuario.Rol,
            FotoPerfil = usuario.FotoPerfil
        };
    }

    private static void ValidarTexto(string valor, string mensaje, int longitudMaxima)
    {
        if (string.IsNullOrWhiteSpace(valor))
        {
            throw new ArgumentException(mensaje);
        }

        if (valor.Length > longitudMaxima)
        {
            throw new ArgumentException($"El valor no puede superar los {longitudMaxima} caracteres.");
        }
    }
}
