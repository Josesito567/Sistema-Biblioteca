namespace Sistema_Biblioteca;

using System;
using System.Windows.Forms;
using Sistema_Biblioteca.Vistas.Autenticacion;
using Sistema_Biblioteca.Vistas.Inicio;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // Mostrar el formulario de acceso
        using (var login = new FrmLogin())
        {
            var resultado = login.ShowDialog();

            if (resultado != DialogResult.OK)
            {
                return;
            }
        }

        // Iniciar la ventana principal
        Application.Run(new FrmInicio());
    }
}