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
        dgvAutores = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvAutores).BeginInit();
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
        lblTitulo.Size = new Size(85, 29);
        lblTitulo.TabIndex = 4;
        lblTitulo.Text = "Autores";
        // 
        // lblDescripcion
        // 
        lblDescripcion.AutoSize = true;
        lblDescripcion.Depth = 0;
        lblDescripcion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        lblDescripcion.Location = new Point(26, 65);
        lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(200, 19);
        lblDescripcion.TabIndex = 3;
        lblDescripcion.Text = "Panel de gestión de autores.";
        // 
        // dgvAutores
        // 
        dgvAutores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvAutores.BackgroundColor = Color.White;
        dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAutores.Location = new Point(25, 87);
        dgvAutores.Name = "dgvAutores";
        dgvAutores.Size = new Size(1020, 480);
        dgvAutores.TabIndex = 2;
        // 
        // UcAutores
        // 
        Controls.Add(dgvAutores);
        Controls.Add(lblDescripcion);
        Controls.Add(lblTitulo);
        Name = "UcAutores";
        Size = new Size(1070, 624);
        ((System.ComponentModel.ISupportInitialize)dgvAutores).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialLabel lblTitulo;
    private MaterialSkin.Controls.MaterialLabel lblDescripcion;
    private DataGridView dgvAutores;
}
