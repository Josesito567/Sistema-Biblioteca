using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;



namespace Sistema_Biblioteca.Vistas.Modales
{
    public partial class NuevoAutor : MaterialForm
    {
        private readonly Sistema_Biblioteca.Modelos.AutoresModelo? autorEditar;

        public NuevoAutor(Sistema_Biblioteca.Modelos.AutoresModelo? autor = null)
        {
            autorEditar = autor;
            InitializeComponent();

            // Registrar el formulario en el gestor de temas
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Ajustes de ventana modal
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            Text = autorEditar is null ? "Nuevo autor" : "Editar autor";

            if (autorEditar is not null)
            {
                txtNombreAutor.Text = autorEditar.nombre;
                txtNacionalidadEAutor.Text = autorEditar.nacionalidad ?? "";
                txtTelefonoAutor.Text = autorEditar.telefono ?? "";
                txtEmailAutor.Text = autorEditar.email ?? "";
                dtpRegistroAutor.Value = autorEditar.fecha_registro == default
                    ? DateTime.Today
                    : autorEditar.fecha_registro;
                btnGuardarAutor.Text = "Actualizar";
            }
        }

        private void btnGuardarAutor_Click(object sender, EventArgs e)
        {

            //Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombreAutor.Text) ||
                string.IsNullOrWhiteSpace(txtNacionalidadEAutor.Text) ||
                string.IsNullOrWhiteSpace(dtpRegistroAutor.Text) ||
                string.IsNullOrWhiteSpace(txtEmailAutor.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoAutor.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // guardar el nuevo autor en la base de datos
            var nuevoAutor = new Sistema_Biblioteca.Modelos.AutoresModelo
            {
                nombre = txtNombreAutor.Text,
                nacionalidad = txtNacionalidadEAutor.Text,
                fecha_registro = dtpRegistroAutor.Value,
                email = txtEmailAutor.Text,
                telefono = txtTelefonoAutor.Text,
                estado = 1 // Activo
            };

            // Valirdar que la categoría no exista ya en la base de datos
            if (Sistema_Biblioteca.Controladores.AutoresControlador.GetAll().Exists(a =>
                a.id_autores != (autorEditar?.id_autores ?? 0) &&
                a.nombre.Equals(nuevoAutor.nombre, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("El autor ya existe en la base de datos.", "Autor existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar el nuevo autor en la base de datos
            if (autorEditar is null)
            {
                Sistema_Biblioteca.Controladores.AutoresControlador.Create(nuevoAutor);
            }
            else
            {
                nuevoAutor.id_autores = autorEditar.id_autores;
                nuevoAutor.estado = autorEditar.estado;
                Sistema_Biblioteca.Controladores.AutoresControlador.Update(nuevoAutor);
            }

            // Mostrar mensaje de éxito
            MessageBox.Show(
                autorEditar is null
                    ? "El autor se ha guardado correctamente."
                    : "El autor se ha actualizado correctamente.",
                "Operación completada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();

        }
    }
}