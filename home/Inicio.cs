namespace Sistema_Biblioteca.home;

using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Sistema_Biblioteca.home.views;

public partial class Inicio : MaterialForm
{
    private bool estaCerrandoSesion = false;

    public Inicio()
    {
        InitializeComponent();

        // 1. Configuración del gestor de temas MaterialSkin
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);

        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Indigo800,   // Azul marino principal
            Primary.Indigo900,   // Sombra azul oscuro
            Primary.Indigo500,   // Acento secundario
            Accent.Red700,       // Rojo antorcha
            TextShade.WHITE      // Texto blanco sobre barra
        );

        // 2. Control de estado de la ventana
        this.MaximizeBox = true;
        this.MinimizeBox = true;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.WindowState = FormWindowState.Maximized;

        if (Screen.PrimaryScreen != null)
        {
            this.MinimumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        // 3. Eventos de navegación del Sidebar
        this.btnHome.Click += (s, e) => CambiarEstiloBotonYVista(btnHome, new UcLibros());
        this.btnPublisher.Click += (s, e) => CambiarEstiloBotonYVista(btnPublisher, new UcPrestamos());
        this.btnAuthors.Click += (s, e) => CambiarEstiloBotonYVista(btnAuthors, new UcPrestamos()); // Reemplazar por UcAuthors al crearlo
        this.btnCerrarSesion.Click += BtnCerrarSesion_Click;

        // 4. Suscribir evento de cierre para controlar la salida
        this.FormClosing += Inicio_FormClosing;

        // Cargar vista por defecto al iniciar
        CambiarEstiloBotonYVista(btnHome, new UcLibros());
    }

    // Cambia la vista del panel contenedor y resalta el botón activo
    private void CargarVista(UserControl vista)
    {
        pnlContenido.Controls.Clear();
        vista.Dock = DockStyle.Fill;
        pnlContenido.Controls.Add(vista);
        pnlContenido.Tag = vista;
        vista.BringToFront();
    }

    private void CambiarEstiloBotonYVista(MaterialButton botonActivo, UserControl vista)
    {
        btnHome.Type = MaterialButton.MaterialButtonType.Outlined;
        btnPublisher.Type = MaterialButton.MaterialButtonType.Outlined;
        btnAuthors.Type = MaterialButton.MaterialButtonType.Outlined;

        botonActivo.Type = MaterialButton.MaterialButtonType.Contained;
        CargarVista(vista);
    }

    private void BtnCerrarSesion_Click(object? sender, EventArgs e)
    {
        var respuesta = MessageBox.Show(
            "¿Está seguro de que desea cerrar la sesión?",
            "Cerrar Sesión",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (respuesta == DialogResult.Yes)
        {
            estaCerrandoSesion = true;
            this.DialogResult = DialogResult.OK; // Opcional para notificar retorno
            this.Close(); // Invoca el evento FormClosing de manera controlada
        }
    }

    private void Inicio_FormClosing(object? sender, FormClosingEventArgs e)
    {
        // Si el usuario presiona la "X" directamente sin pulsar "Cerrar Sesión"
        if (!estaCerrandoSesion && e.CloseReason == CloseReason.UserClosing)
        {
            var respuesta = MessageBox.Show(
                "¿Desea salir completamente de la aplicación?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true; // Cancela el cierre de la ventana
            }
            else
            {
                Application.Exit(); // Cierra todo el proceso limpiamente
            }
        }
    }
}