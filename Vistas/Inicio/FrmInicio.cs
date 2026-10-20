namespace Sistema_Biblioteca.Vistas.Inicio;

using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Sistema_Biblioteca.Controles;
using Sistema_Biblioteca.Modelos;
using Sistema_Biblioteca.Servicios;
using Sistema_Biblioteca.Vistas.Inicio.Paginas;

public partial class FrmInicio : MaterialForm
{
    private bool estaCerrandoSesion = false;
    private readonly string rolUsuario;
    private readonly MaterialButton btnAdministracion;
    private readonly UsuarioSesion usuarioActual;

    public FrmInicio(UsuarioSesion? usuarioActual = null)
    {
        this.usuarioActual = usuarioActual ?? new UsuarioSesion
        {
            Nombre = "Usuario",
            Usuario = "usuario",
            Rol = "normal"
        };
        rolUsuario = this.usuarioActual.Rol;
        InitializeComponent();
        btnAdministracion = CrearBotonAdministracion();
        ConfigurarPerfilUsuario();

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
        this.btnInicio.Click += (s, e) => MostrarInicio();
        this.btnLibros.Click += (s, e) => CambiarVista(btnLibros, new UcCatalogoLibros());
        this.btnAutores.Click += (s, e) => CambiarVista(btnAutores, new UcAutores());
        this.btnCategorias.Click += (s, e) => CambiarVista(btnCategorias, new UcCategorias());
        this.btnEditoriales.Click += (s, e) => CambiarVista(btnEditoriales, new UcEditoriales());
        this.btnAyuda.Click += (s, e) => CambiarVista(btnAyuda, new UcAyuda());
        btnAdministracion.Click += (s, e) => CambiarVista(btnAdministracion, new UcAdministracion());
        this.btnCerrarSesion.Click += BtnCerrarSesion_Click;

        // Suscribir evento de cierre para confirmar salida
        this.FormClosing += FrmInicio_FormClosing;
        this.KeyPreview = true;
        this.KeyDown += FrmInicio_KeyDown;
        MostrarInicio();
    }

    private void CargarVista(UserControl vista)
    {
        pnlContenido.SuspendLayout();

        try
        {
            LimpiarContenido();
            vista.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(vista);
            pnlContenido.Tag = vista;
            vista.BringToFront();
        }
        finally
        {
            pnlContenido.ResumeLayout(true);
        }
    }

    private void CambiarVista(MaterialButton botonActivo, UserControl vista)
    {
        ActivarBoton(botonActivo);

        if (pnlContenido.Controls.Count > 0 &&
            pnlContenido.Controls[0].GetType() == vista.GetType())
        {
            vista.Dispose();
            return;
        }

        CargarVista(vista);
    }

    private void MostrarInicio()
    {
        CambiarVista(btnInicio, new UcDashboard());
    }

    private void LimpiarContenido()
    {
        while (pnlContenido.Controls.Count > 0)
        {
            var vistaAnterior = pnlContenido.Controls[0];
            pnlContenido.Controls.RemoveAt(0);
            vistaAnterior.Dispose();
        }
    }

    private void ActivarBoton(MaterialButton botonActivo)
    {
        btnInicio.Type = MaterialButton.MaterialButtonType.Outlined;
        btnLibros.Type = MaterialButton.MaterialButtonType.Outlined;
        btnAutores.Type = MaterialButton.MaterialButtonType.Outlined;
        btnCategorias.Type = MaterialButton.MaterialButtonType.Outlined;
        btnEditoriales.Type = MaterialButton.MaterialButtonType.Outlined;
        btnAyuda.Type = MaterialButton.MaterialButtonType.Outlined;
        btnAdministracion.Type = MaterialButton.MaterialButtonType.Outlined;

        botonActivo.Type = MaterialButton.MaterialButtonType.Contained;
    }

    private MaterialButton CrearBotonAdministracion()
    {
        var boton = new MaterialButton
        {
            AutoSize = false,
            Depth = 0,
            DrawShadows = true,
            HighEmphasis = true,
            Icon = null,
            Location = new System.Drawing.Point(12, 340),
            Margin = new Padding(4, 6, 4, 6),
            MouseState = MouseState.HOVER,
            Name = "btnAdministracion",
            Size = new System.Drawing.Size(196, 40),
            TabIndex = 6,
            Text = "Administración",
            Type = MaterialButton.MaterialButtonType.Outlined,
            UseAccentColor = false,
            UseVisualStyleBackColor = true,
            Visible = rolUsuario.Equals("admin", StringComparison.OrdinalIgnoreCase)
        };

        pnlBarraLateral.Controls.Add(boton);
        btnAyuda.Location = new Point(12, boton.Visible ? 390 : 340);
        return boton;
    }

    private void ConfigurarPerfilUsuario()
    {
        var datosFoto = usuarioActual.FotoPerfil is { Length: > 0 }
            ? usuarioActual.FotoPerfil
            : AvatarImagenServicio.CrearAvatarPredeterminado(usuarioActual.Usuario);

        try
        {
            using var flujo = new MemoryStream(datosFoto);
            using var imagen = Image.FromStream(flujo);
            picFotoPerfil.Image = new Bitmap(imagen);
        }
        catch (ArgumentException)
        {
            using var flujo = new MemoryStream(
                AvatarImagenServicio.CrearAvatarPredeterminado(usuarioActual.Usuario));
            using var imagen = Image.FromStream(flujo);
            picFotoPerfil.Image = new Bitmap(imagen);
        }

        lblNombreUsuario.Text = usuarioActual.Nombre;
        lblTagUsuario.Text = $"@{usuarioActual.Usuario} · {usuarioActual.Rol}";
    }

    private void FrmInicio_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
        {
            return;
        }

        var controlActivo = ObtenerControlConFoco(this);
        if (controlActivo is MaterialTextBox2)
        {
            SelectNextControl(controlActivo, true, true, true, true);
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }

    private static Control? ObtenerControlConFoco(Control control)
    {
        foreach (Control hijo in control.Controls)
        {
            if (hijo.Focused)
            {
                return hijo;
            }

            if (hijo.ContainsFocus)
            {
                return ObtenerControlConFoco(hijo);
            }
        }

        return control.Focused ? control : null;
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
                estaCerrandoSesion = true;
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}