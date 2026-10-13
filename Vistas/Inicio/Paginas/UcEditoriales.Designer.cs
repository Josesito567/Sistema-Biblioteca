namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

partial class UcEditoriales
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
        dgvEditoriales = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvEditoriales).BeginInit();
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
        lblTitulo.Size = new Size(115, 29);
        lblTitulo.TabIndex = 1;
        lblTitulo.Text = "Editoriales";
        // 
        // lblDescripcion
        // 
        lblDescripcion.AutoSize = true;
        lblDescripcion.Depth = 0;
        lblDescripcion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        lblDescripcion.Location = new Point(26, 65);
        lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(220, 19);
        lblDescripcion.TabIndex = 0;
        lblDescripcion.Text = "Panel de gestión de editoriales.";
        // 
        // dgvEditoriales
        // 
        dgvEditoriales.AccessibleDescription = "dgvEditoriales";
        dgvEditoriales.BackgroundColor = Color.White;
        dgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvEditoriales.Location = new Point(25, 103);
        dgvEditoriales.Name = "dgvEditoriales";
        dgvEditoriales.Size = new Size(1202, 416);
        dgvEditoriales.TabIndex = 2;
        // 
        // UcEditoriales
        // 
        Controls.Add(dgvEditoriales);
        Controls.Add(lblDescripcion);
        Controls.Add(lblTitulo);
        Name = "UcEditoriales";
        Size = new Size(1248, 625);
        ((System.ComponentModel.ISupportInitialize)dgvEditoriales).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialLabel lblTitulo;
    private MaterialSkin.Controls.MaterialLabel lblDescripcion;
    private DataGridView dgvEditoriales;
}
