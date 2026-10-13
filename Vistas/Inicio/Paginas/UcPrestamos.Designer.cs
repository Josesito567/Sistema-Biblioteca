namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

partial class UcPrestamos
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    private void InitializeComponent()
    {
        lblTitulo = new MaterialSkin.Controls.MaterialLabel();
        lblSubtitulo = new MaterialSkin.Controls.MaterialLabel();
        dgvPrestamos = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
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
        lblTitulo.Size = new Size(403, 29);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Control de Préstamos y Devoluciones";
        // 
        // lblSubtitulo
        // 
        lblSubtitulo.AutoSize = true;
        lblSubtitulo.Depth = 0;
        lblSubtitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        lblSubtitulo.Location = new Point(26, 60);
        lblSubtitulo.MouseState = MaterialSkin.MouseState.HOVER;
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(276, 19);
        lblSubtitulo.TabIndex = 1;
        lblSubtitulo.Text = "Registro de salidas y entregas de libros";
        // 
        // dgvPrestamos
        // 
        dgvPrestamos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvPrestamos.BackgroundColor = Color.White;
        dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPrestamos.Location = new Point(26, 82);
        dgvPrestamos.Name = "dgvPrestamos";
        dgvPrestamos.Size = new Size(777, 439);
        dgvPrestamos.TabIndex = 2;
        // 
        // UcPrestamos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblSubtitulo);
        Controls.Add(dgvPrestamos);
        Controls.Add(lblTitulo);
        Name = "UcPrestamos";
        Size = new Size(838, 550);
        ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MaterialSkin.Controls.MaterialLabel lblTitulo;
    private MaterialSkin.Controls.MaterialLabel lblSubtitulo;
    private DataGridView dgvPrestamos;
}