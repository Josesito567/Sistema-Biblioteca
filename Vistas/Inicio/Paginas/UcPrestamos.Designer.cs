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
        txtBuscar = new MaterialSkin.Controls.MaterialTextBox2();
        btnBuscar = new MaterialSkin.Controls.MaterialButton();
        btnRefrescar = new MaterialSkin.Controls.MaterialButton();
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
        // txtBuscar
        // 
        txtBuscar.Location = new Point(25, 87);
        txtBuscar.Name = "txtBuscar";
        txtBuscar.Size = new Size(280, 48);
        txtBuscar.TabIndex = 3;
        // 
        // btnBuscar
        // 
        btnBuscar.Location = new Point(320, 93);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(105, 36);
        btnBuscar.TabIndex = 4;
        btnBuscar.Text = "Buscar";
        btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnBuscar.Click += btnBuscar_Click;
        // 
        // btnRefrescar
        // 
        btnRefrescar.Location = new Point(435, 93);
        btnRefrescar.Name = "btnRefrescar";
        btnRefrescar.Size = new Size(105, 36);
        btnRefrescar.TabIndex = 5;
        btnRefrescar.Text = "Refrescar";
        btnRefrescar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        btnRefrescar.Click += btnRefrescar_Click;
        // 
        // dgvPrestamos
        // 
        dgvPrestamos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvPrestamos.BackgroundColor = Color.White;
        dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPrestamos.Location = new Point(25, 145);
        dgvPrestamos.Name = "dgvPrestamos";
        dgvPrestamos.Size = new Size(777, 439);
        dgvPrestamos.TabIndex = 2;
        // 
        // UcPrestamos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(btnRefrescar);
        Controls.Add(btnBuscar);
        Controls.Add(txtBuscar);
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
    private MaterialSkin.Controls.MaterialTextBox2 txtBuscar;
    private MaterialSkin.Controls.MaterialButton btnBuscar;
    private MaterialSkin.Controls.MaterialButton btnRefrescar;
}