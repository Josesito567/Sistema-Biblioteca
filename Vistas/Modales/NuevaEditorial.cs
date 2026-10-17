namespace Sistema_Biblioteca.Vistas.Modales;
using MaterialSkin;
using MaterialSkin.Controls;
using Sistema_Biblioteca.Controladores;
using Sistema_Biblioteca.Modelos;
using System;
using System.Windows.Forms;
using System.Xml.Linq;


public partial class NuevaEditorial : MaterialForm
{
    public NuevaEditorial()
    {
        InitializeComponent();

        // Registrar el formulario en el gestor de temas
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);

        // Ajustes de ventana modal
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.StartPosition = FormStartPosition.CenterParent;
    }

    private void NuevaEditorial_Load(object sender, EventArgs e)
    {

    }

    private void materialTextBox21_Click(object sender, EventArgs e)
    {

    }

    private void btnGuardarEditorial_Click(object sender, EventArgs e)
    {
        //Validar campos vacíos
        if (string.IsNullOrWhiteSpace(txtNombreEditorial.Text) ||
            string.IsNullOrWhiteSpace(txtDireccionEditorial.Text) ||
            string.IsNullOrWhiteSpace(txtCiudadEditorial.Text) ||
            string.IsNullOrWhiteSpace(txtTelefonoEditorial.Text) ||
            string.IsNullOrWhiteSpace(txtEmailEditorial.Text))
        {
            MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        EditorialesModelo creareditorial = new EditorialesModelo
          {
              nombre = txtNombreEditorial.Text.Trim(),
              direccion = txtDireccionEditorial.Text.Trim(),
              ciudad = txtCiudadEditorial.Text.Trim(),
              telefono = txtTelefonoEditorial.Text.Trim(),
              email = txtEmailEditorial.Text.Trim(),
              estado = 1, // Estado activo

          };
        try
        {
            EditorialesControlador.Create(creareditorial);

            MessageBox.Show(
                "La editorial se guardó correctamente.",
                "Editorial guardada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"No se pudo guardar la editorial.\n\nDetalle: {ex.Message}",
                "Error al guardar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

}