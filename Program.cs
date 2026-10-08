namespace Sistema_Biblioteca;

using System;
using System.Windows.Forms;
using Sistema_Biblioteca.auth;
using Sistema_Biblioteca.home;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // 1. Instanciamos y mostramos el Login como un diálogo modal
        using (var login = new Form1())
        {
            // ShowDialog detiene la ejecución de Main hasta que Form1 se cierre
            var resultado = login.ShowDialog();

            // 2. Si el login no fue exitoso (el usuario cerró la ventana con la X), terminamos el programa
            if (resultado != DialogResult.OK)
            {
                return; // Sale de Main y la aplicación finaliza
            }
        }

        // 3. Si llegó aquí, significa que la contraseña fue correcta y el Login ya se destruyó de la memoria.
        // Ahora sí arrancamos el bucle principal de la aplicación con la pantalla de Inicio:
        Application.Run(new Inicio());
    }
}