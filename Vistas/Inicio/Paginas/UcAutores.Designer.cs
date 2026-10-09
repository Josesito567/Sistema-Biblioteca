namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

partial class UcAutores
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new MaterialSkin.Controls.MaterialLabel();
        lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
        SuspendLayout();
        lblTitulo.AutoSize = true;
        lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
        lblTitulo.Location = new System.Drawing.Point(25, 25);
        lblTitulo.Text = "Autores";
        lblDescripcion.AutoSize = true;
        lblDescripcion.Location = new System.Drawing.Point(26, 65);
        lblDescripcion.Text = "Panel de gestión de autores.";
        Controls.Add(lblDescripcion);
        Controls.Add(lblTitulo);
        Name = "UcAutores";
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialLabel lblTitulo;
    private MaterialSkin.Controls.MaterialLabel lblDescripcion;
}
