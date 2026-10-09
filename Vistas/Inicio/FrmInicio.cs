namespace Sistema_Biblioteca.Vistas.Inicio;

using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Sistema_Biblioteca.Vistas.Inicio.Paginas;

public partial class FrmInicio : MaterialForm
{
    private bool estaCerrandoSesion = false;

    public FrmInicio()
    {
        InitializeComponent();

        // Configuración del gestor de temas
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

        // Parámetros de la ventana
        this.MaximizeBox = true;
        this.MinimizeBox = true;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.WindowState = FormWindowState.Maximized;

        if (Screen.PrimaryScreen != null)
        {
            this.MinimumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        // Eventos de navegación del menú lateral
        this.btnLibros.Click += (s, e) => CambiarVista(btnLibros, new UcLibros());
        this.btnAyuda.Click += (s, e) => CambiarVista(btnAyuda, new UcAyuda());
        this.btnCerrarSesion.Click += BtnCerrarSesion_Click;

        // Suscribir evento de cierre para confirmar salida
        this.FormClosing += FrmInicio_FormClosing;

        CambiarVista(btnLibros, new UcLibros());
    }

    private void CargarVista(UserControl vista)
    {
        pnlContenido.Controls.Clear();
        vista.Dock = DockStyle.Fill;
        pnlContenido.Controls.Add(vista);
        pnlContenido.Tag = vista;
        vista.BringToFront();
    }

    private void CambiarVista(MaterialButton botonActivo, UserControl vista)
    {
        btnLibros.Type = MaterialButton.MaterialButtonType.Outlined;
        btnAyuda.Type = MaterialButton.MaterialButtonType.Outlined;

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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    private void FrmInicio_FormClosing(object? sender, FormClosingEventArgs e)
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
                Application.Exit();
            }
        }
    }
}