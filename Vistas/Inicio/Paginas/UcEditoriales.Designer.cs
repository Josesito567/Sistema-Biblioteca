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
        dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
        // dataGridView1
        // 
        dataGridView1.AccessibleDescription = "DgvTablaEditorial";
        dataGridView1.BackgroundColor = Color.White;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(25, 131);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(595, 255);
        dataGridView1.TabIndex = 2;
        // 
        // UcEditoriales
        // 
        Controls.Add(dataGridView1);
        Controls.Add(lblDescripcion);
        Controls.Add(lblTitulo);
        Name = "UcEditoriales";
        Size = new Size(650, 433);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialLabel lblTitulo;
    private MaterialSkin.Controls.MaterialLabel lblDescripcion;
    private DataGridView dataGridView1;
}
