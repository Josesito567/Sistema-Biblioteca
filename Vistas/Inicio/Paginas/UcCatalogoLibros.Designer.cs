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
        btnLiCrear = new MaterialSkin.Controls.MaterialButton();
        txtBuscar = new MaterialSkin.Controls.MaterialTextBox2();
        btnBuscar = new MaterialSkin.Controls.MaterialButton();
        btnRefrescar = new MaterialSkin.Controls.MaterialButton();
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
        // txtBuscar
        // 
        txtBuscar.Location = new Point(25, 87);
        txtBuscar.Name = "txtBuscar";
        txtBuscar.Size = new Size(280, 48);
        txtBuscar.TabIndex = 6;
        // 
        // btnBuscar
        // 
        btnBuscar.Location = new Point(320, 93);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(105, 36);
        btnBuscar.TabIndex = 7;
        btnBuscar.Text = "Buscar";
        btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnBuscar.Click += btnBuscar_Click;
        // 
        // btnRefrescar
        // 
        btnRefrescar.Location = new Point(435, 93);
        btnRefrescar.Name = "btnRefrescar";
        btnRefrescar.Size = new Size(105, 36);
        btnRefrescar.TabIndex = 8;
        btnRefrescar.Text = "Refrescar";
        btnRefrescar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        btnRefrescar.Click += btnRefrescar_Click;
        // 
        // dgvCatalogoLibros
        // 
        dgvCatalogoLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvCatalogoLibros.BackgroundColor = Color.White;
        dgvCatalogoLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCatalogoLibros.Location = new Point(25, 145);
        dgvCatalogoLibros.Name = "dgvCatalogoLibros";
        dgvCatalogoLibros.Size = new Size(879, 460);
        dgvCatalogoLibros.TabIndex = 2;
        // 
        // btnLiCrear
        // 
        btnLiCrear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLiCrear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnLiCrear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnLiCrear.Depth = 0;
        btnLiCrear.HighEmphasis = true;
        btnLiCrear.Icon = null;
        btnLiCrear.Location = new Point(790, 42);
        btnLiCrear.Margin = new Padding(4, 6, 4, 6);
        btnLiCrear.MouseState = MaterialSkin.MouseState.HOVER;
        btnLiCrear.Name = "btnLiCrear";
        btnLiCrear.NoAccentTextColor = Color.Empty;
        btnLiCrear.Size = new Size(114, 36);
        btnLiCrear.TabIndex = 5;
         btnLiCrear.Text = "Nuevo ejemplar";
        btnLiCrear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnLiCrear.UseAccentColor = false;
        btnLiCrear.UseVisualStyleBackColor = true;
        btnLiCrear.Click += btnLiCrear_Click;
        // 
        // UcCatalogoLibros
        // 
        Controls.Add(btnRefrescar);
        Controls.Add(btnBuscar);
        Controls.Add(txtBuscar);
        Controls.Add(btnLiCrear);
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
    private MaterialSkin.Controls.MaterialButton btnLiCrear;
    private MaterialSkin.Controls.MaterialTextBox2 txtBuscar;
    private MaterialSkin.Controls.MaterialButton btnBuscar;
    private MaterialSkin.Controls.MaterialButton btnRefrescar;
}
