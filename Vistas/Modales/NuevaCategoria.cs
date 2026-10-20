using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema_Biblioteca.Vistas;

namespace Sistema_Biblioteca.Vistas.Modales
{
    public partial class NuevaCategoria : MaterialForm
    {
        public NuevaCategoria()
        {

            InitializeComponent();
            ResponsiveLayout.Apply(this);

            // Registrar el formulario en el gestor de temas
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Ajustes de ventana modal
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void NuevaCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            // Validar que el campo de nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Guardar la nueva categoría en la base de datos
            var nuevaCategoria = new Sistema_Biblioteca.Modelos.CategoriasModelo
            {
                nombre = txtNombreCategoria.Text,
                descripcion = txtDescripcionCategoria.Text,
                estado = 1, // Activo
                fecha_registro = DateTime.Now
            };

            // Valirdar que la categoría no exista ya en la base de datos
            if (Sistema_Biblioteca.Controladores.CategoriasControlador.ExisteNombre(nuevaCategoria.nombre))
            {
                MessageBox.Show("Ya existe una categoría con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Aquí deberías agregar la lógica para guardar la nueva categoría en la base de datos
            Sistema_Biblioteca.Controladores.CategoriasControlador.Create(nuevaCategoria);

            // Mostrar mensaje de éxito
            MessageBox.Show("La categoría ha sido guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos del formulario
            txtNombreCategoria.Clear();
            txtDescripcionCategoria.Clear();

            // Cerrar el formulario modal
            this.Close();

        }
    }
}
