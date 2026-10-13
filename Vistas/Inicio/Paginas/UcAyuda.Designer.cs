namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

partial class UcAyuda
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
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Depth = 0;
        lblTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
        lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
        lblTitulo.Location = new Point(25, 25);
        lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(68, 29);
        lblTitulo.TabIndex = 1;
        lblTitulo.Text = "Ayuda";
        // 
        // lblDescripcion
        // 
        lblDescripcion.AutoSize = true;
        lblDescripcion.Depth = 0;
        lblDescripcion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        lblDescripcion.Location = new Point(26, 65);
        lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(293, 19);
        lblDescripcion.TabIndex = 0;
        lblDescripcion.Text = "Panel de ayuda del sistema de biblioteca.";
        // 
        // UcAyuda
        // 
        Controls.Add(lblDescripcion);
        Controls.Add(lblTitulo);
        Name = "UcAyuda";
        Size = new Size(872, 586);
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialLabel lblTitulo;
    private MaterialSkin.Controls.MaterialLabel lblDescripcion;
}
