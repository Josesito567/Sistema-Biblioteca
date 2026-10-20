namespace Sistema_Biblioteca;

using System;
using System.Windows.Forms;
using Sistema_Biblioteca.Data;
using Sistema_Biblioteca.Vistas.Autenticacion;
using Sistema_Biblioteca.Vistas.Inicio;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        UsuariosSeeder.Seed();

        while (true)
        {
            using (var login = new FrmLogin())
            {
                var resultado = login.ShowDialog();

                if (resultado != DialogResult.OK)
                {
                    return;
                }

                using var inicio = new FrmInicio(login.UsuarioActual);
                var resultadoInicio = inicio.ShowDialog();

                if (resultadoInicio != DialogResult.OK)
                {
                    return;
                }
            }
        }
    }
}