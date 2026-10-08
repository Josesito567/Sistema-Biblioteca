namespace Sistema_Biblioteca;
using Sistema_Biblioteca.auth.Contacto;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;

public partial class Form1 : MaterialForm
{
    public Form1()
    {
        InitializeComponent();

        //posicion y ajuste de resolucion
        // Ajustes típicos para una ventana modal
        this.MaximizeBox = false;
        this.MinimizeBox = true;
        this.StartPosition = FormStartPosition.CenterParent;

        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);

        // Mantenemos el tema claro para el contraste de lectura
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

        // Paleta basada en el Azul Marino Institucional y Rojo Antorcha del Colegio Tilburg
        materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Indigo800,   // Azul principal para la barra superior
            Primary.Indigo900,   // Azul marino más profundo
            Primary.Indigo500,   // Azul medio
            Accent.Red700,       // Rojo de la antorcha para el botón "INGRESAR"
            TextShade.WHITE      // Texto en blanco sobre el azul
        );
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Rutas basadas en tu carpeta 'resources'
        string rutaOjoAbierto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", "ojo.png");
        string rutaOjoCerrado = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", "ojo cerrado.png");

        // 1. Ocultar el texto por defecto (modo contraseña)
        txtcontraseña.UseSystemPasswordChar = true;

        // 2. Cargar el icono inicial si el archivo existe
        if (File.Exists(rutaOjoCerrado))
        {
            txtcontraseña.TrailingIcon = Image.FromFile(rutaOjoCerrado);
        }

        // 3. Evento al hacer clic sobre el icono dentro del campo
        txtcontraseña.TrailingIconClick += (s, args) =>
        {
            // Alternamos el estado de visibilidad
            txtcontraseña.UseSystemPasswordChar = !txtcontraseña.UseSystemPasswordChar;

            // Cambiamos el icono según el estado
            if (txtcontraseña.UseSystemPasswordChar)
            {
                if (File.Exists(rutaOjoCerrado))
                    txtcontraseña.TrailingIcon = Image.FromFile(rutaOjoCerrado);
            }
            else
            {
                if (File.Exists(rutaOjoAbierto))
                    txtcontraseña.TrailingIcon = Image.FromFile(rutaOjoAbierto);
            }
        };
    }

    private void materialCard1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
    {

    }

    private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
    {
        using (var modal = new Sistema_Biblioteca.auth.Contacto.FrmContacto())
        {
            modal.ShowDialog(this);
        }
    }

    private void materialButton1_Click(object sender, System.EventArgs e)
    {
        // 1. Obtenemos el texto limpio (sin espacios extras a los lados)
        string correo = txtcorreo.Text.Trim();
        string contraseña = txtcontraseña.Text.Trim();

        // 2. Validamos que NINGUNO de los dos campos esté vacío
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