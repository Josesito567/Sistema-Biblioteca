namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

partial class UcCatalogoLibros
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
        dgvCatalogoLibros = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvCatalogoLibros).BeginInit();
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
        lblTitulo.Size = new Size(67, 29);
        lblTitulo.TabIndex = 4;
        lblTitulo.Text = "Libros";
        // 
        // lblDescripcion
        // 
        lblDescripcion.AutoSize = true;
        lblDescripcion.Depth = 0;
        lblDescripcion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        lblDescripcion.Location = new Point(26, 65);
        lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(263, 19);
        lblDescripcion.TabIndex = 3;
        lblDescripcion.Text = "Panel de gestión y consulta de libros.";
        // 
        // dgvCatalogoLibros
        // 
        dgvCatalogoLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvCatalogoLibros.BackgroundColor = Color.White;
        dgvCatalogoLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCatalogoLibros.Location = new Point(25, 87);
        dgvCatalogoLibros.Name = "dgvCatalogoLibros";
        dgvCatalogoLibros.Size = new Size(879, 460);
        dgvCatalogoLibros.TabIndex = 2;
        // 
        // UcCatalogoLibros
        // 
        Controls.Add(dgvCatalogoLibros);
        Controls.Add(lblDescripcion);
        Controls.Add(lblTitulo);
        Name = "UcCatalogoLibros";
        Size = new Size(934, 573);
        ((System.ComponentModel.ISupportInitialize)dgvCatalogoLibros).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialLabel lblTitulo;
    private MaterialSkin.Controls.MaterialLabel lblDescripcion;
    private DataGridView dgvCatalogoLibros;
}
