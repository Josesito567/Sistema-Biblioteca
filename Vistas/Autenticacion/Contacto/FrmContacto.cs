namespace Sistema_Biblioteca.Vistas.Autenticacion.Contacto;

using System;
using MaterialSkin;
using MaterialSkin.Controls;

public partial class FrmContacto : MaterialForm
{
    public FrmContacto()
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