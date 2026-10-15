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
        public NuevoAutor()
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
    }
}
