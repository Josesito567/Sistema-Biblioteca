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

        while (true)
        {
            using (var login = new FrmLogin())
            {
                var resultado = login.ShowDialog();

                if (resultado != DialogResult.OK)
                {
                    return;
                }
            }

            using var inicio = new FrmInicio();
            inicio.ShowDialog();
        }
    }
}