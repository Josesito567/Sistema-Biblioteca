using MaterialSkin;
using MaterialSkin.Controls;
using Sistema_Biblioteca.Controladores;
using System.Drawing;

namespace Sistema_Biblioteca.Vistas.Autenticacion;

public sealed class FrmRegistroUsuario : MaterialForm
{
    private readonly MaterialTextBox2 txtNombre = new();
    private readonly MaterialTextBox2 txtUsuario = new();
    private readonly MaterialTextBox2 txtContrasena = new();
    private readonly MaterialTextBox2 txtConfirmarContrasena = new();
    private readonly MaterialButton btnCrearUsuario = new();

    public FrmRegistroUsuario()
    {
        Text = "Crear nuevo usuario";
        StartPosition = FormStartPosition.CenterParent;
        MaximizeBox = false;
        MinimizeBox = false;
        ClientSize = new Size(430, 390);
        AcceptButton = btnCrearUsuario;
        KeyPreview = true;

        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

        ConstruirFormulario();
    }

    private void ConstruirFormulario()
    {
        var panel = new Panel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(24)
        };

        var lblTitulo = new MaterialLabel
        {
            AutoSize = true,
            FontType = MaterialSkinManager.fontType.H5,
            Location = new Point(24, 18),
            Text = "Crear cuenta"
        };

        PrepararCampo(txtNombre, "Nombre completo", 24, 62);
        PrepararCampo(txtUsuario, "Usuario", 24, 116);
        PrepararCampo(txtContrasena, "Contraseña", 24, 170);
        PrepararCampo(txtConfirmarContrasena, "Confirmar contraseña", 24, 224);

        txtContrasena.UseSystemPasswordChar = true;
        txtConfirmarContrasena.UseSystemPasswordChar = true;

        btnCrearUsuario.AutoSize = false;
        btnCrearUsuario.Location = new Point(24, 294);
        btnCrearUsuario.Size = new Size(356, 42);
        btnCrearUsuario.Text = "CREAR USUARIO";
        btnCrearUsuario.Type = MaterialButton.MaterialButtonType.Contained;
        btnCrearUsuario.UseAccentColor = true;
        btnCrearUsuario.Click += BtnCrearUsuario_Click;

        panel.Controls.AddRange(new Control[]
        {
            lblTitulo,
            txtNombre,
            txtUsuario,
            txtContrasena,
            txtConfirmarContrasena,
            btnCrearUsuario
        });

        Controls.Add(panel);
    }

    private static void PrepararCampo(MaterialTextBox2 campo, string hint, int x, int y)
    {
        campo.Hint = hint;
        campo.Location = new Point(x, y);
        campo.Size = new Size(356, 48);
        campo.TabStop = true;
    }

    private void InitializeComponent()
    {

    }

    private void BtnCrearUsuario_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtUsuario.Text) ||
            string.IsNullOrWhiteSpace(txtContrasena.Text) ||
            string.IsNullOrWhiteSpace(txtConfirmarContrasena.Text))
        {
            MessageBox.Show("Complete todos los campos.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!txtContrasena.Text.Equals(txtConfirmarContrasena.Text, StringComparison.Ordinal))
        {
            MessageBox.Show("Las contraseñas no coinciden.", "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtConfirmarContrasena.Focus();
            return;
        }

        try
        {
            UsuariosControlador.Registrar(txtNombre.Text, txtUsuario.Text, txtContrasena.Text);
            MessageBox.Show("Usuario creado correctamente. Ya puede iniciar sesión.", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "No se pudo crear el usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
