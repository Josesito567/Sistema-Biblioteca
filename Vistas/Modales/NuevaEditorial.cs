namespace Sistema_Biblioteca.Vistas.Modales;
using System.Windows.Forms;
using System;
using MaterialSkin;
using MaterialSkin.Controls;


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
}