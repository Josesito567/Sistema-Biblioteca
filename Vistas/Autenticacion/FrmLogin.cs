namespace Sistema_Biblioteca.Vistas.Autenticacion;
using Sistema_Biblioteca.Vistas.Autenticacion.Contacto;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;

public partial class FrmLogin : MaterialForm
{
    public FrmLogin()
    {
        InitializeComponent();

        // Posición y ajustes básicos de la ventana
        this.MaximizeBox = false;
        this.MinimizeBox = true;
        this.StartPosition = FormStartPosition.CenterParent;

        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);

        // Tema claro por defecto
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

        // Paleta de colores institucional
        materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Indigo800,   // Azul principal para la barra superior
            Primary.Indigo900,   // Azul marino más profundo
            Primary.Indigo500,   // Azul medio
            Accent.Red700,       // Rojo de la antorcha para el botón "INGRESAR"
            TextShade.WHITE      // Texto en blanco sobre el azul
        );
    }

    private void FrmLogin_Load(object sender, EventArgs e)
    {
        // Obtener las rutas de los iconos
        string rutaOjoAbierto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", "ojo.png");
        string rutaOjoCerrado = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", "ojo cerrado.png");

        // Ocultar la contraseña
        txtContrasena.UseSystemPasswordChar = true;

        // Cargar el icono inicial
        if (File.Exists(rutaOjoCerrado))
        {
            txtContrasena.TrailingIcon = Image.FromFile(rutaOjoCerrado);
        }

        // Alternar la visibilidad de la contraseña
        txtContrasena.TrailingIconClick += (s, args) =>
        {
            txtContrasena.UseSystemPasswordChar = !txtContrasena.UseSystemPasswordChar;

            if (txtContrasena.UseSystemPasswordChar)
            {
                if (File.Exists(rutaOjoCerrado))
                    txtContrasena.TrailingIcon = Image.FromFile(rutaOjoCerrado);
            }
            else
            {
                if (File.Exists(rutaOjoAbierto))
                    txtContrasena.TrailingIcon = Image.FromFile(rutaOjoAbierto);
            }
        };
    }

    private void cardLogin_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
    {

    }

    private void lnkContacto_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
    {
        using (var modal = new FrmContacto())
        {
            modal.ShowDialog(this);
        }
    }

    private void btnIngresar_Click(object sender, System.EventArgs e)
    {
        string correo = txtCorreo.Text.Trim();
        string contraseña = txtContrasena.Text.Trim();

        if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
        {
            MessageBox.Show(
                "Por favor, complete todos los campos para ingresar.", 
                "Campos Requeridos", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Warning
            );
            return; // Detenemos la ejecución aquí
        }

        // 3. Si ambos campos tienen texto, otorgamos el OK y cerramos
        this.DialogResult = DialogResult.OK;
        this.Close();
        
    }
}