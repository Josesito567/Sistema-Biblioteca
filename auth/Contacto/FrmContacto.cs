namespace Sistema_Biblioteca.auth.Contacto;

using System;
using MaterialSkin;
using MaterialSkin.Controls;

public partial class FrmContacto : MaterialForm
{
    public FrmContacto()
    {
        InitializeComponent();

        // Vincula el formulario al gestor de temas global (hereda la paleta azul e índigo)
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);

        // Ajustes típicos para una ventana modal
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.StartPosition = FormStartPosition.CenterParent;
    }
}