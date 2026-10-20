using Microsoft.EntityFrameworkCore;
using Sistema_Biblioteca.Modelos;
using Sistema_Biblioteca.Servicios;

namespace Sistema_Biblioteca.Data;

public static class UsuariosSeeder
{
    public static void Seed()
    {
        using var context = LibraryContextFactory.Create();

        context.Database.ExecuteSqlRaw("""
            IF OBJECT_ID(N'dbo.Usuarios', N'U') IS NULL
            BEGIN
                CREATE TABLE dbo.Usuarios
                (
                    Id INT IDENTITY(1,1) NOT NULL
                        CONSTRAINT PK_Usuarios PRIMARY KEY,
                    Nombre VARCHAR(150) NOT NULL,
                    Usuario VARCHAR(50) NOT NULL,
                    [Password] VARCHAR(255) NOT NULL,
                    Rol VARCHAR(20) NOT NULL
                        CONSTRAINT DF_Usuarios_Rol DEFAULT 'normal',
                    FotoPerfil VARBINARY(MAX) NULL,
                    CONSTRAINT UQ_Usuarios_Usuario UNIQUE (Usuario),
                    CONSTRAINT CK_Usuarios_Rol CHECK (Rol IN ('admin', 'normal'))
                );
            END
            """);

        if (context.Usuarios.Any())
        {
            return;
        }

        context.Usuarios.AddRange(
            new UsuariosModelo
            {
                Nombre = "Administrador",
                Usuario = "admin",
                    Password = PasswordServicio.CrearHash("Admin123!"),
                    Rol = "admin",
                    FotoPerfil = AvatarImagenServicio.CrearAvatarPredeterminado("admin")
            },
            new UsuariosModelo
            {
                Nombre = "Usuario de prueba",
                Usuario = "user",
                    Password = PasswordServicio.CrearHash("User123!"),
                    Rol = "normal",
                    FotoPerfil = AvatarImagenServicio.CrearAvatarPredeterminado("user")
            });

        context.SaveChanges();
    }
}
