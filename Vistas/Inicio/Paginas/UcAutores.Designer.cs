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
        btnAuCrear = new MaterialSkin.Controls.MaterialButton();
        txtBuscar = new MaterialSkin.Controls.MaterialTextBox2();
        btnBuscar = new MaterialSkin.Controls.MaterialButton();
        btnRefrescar = new MaterialSkin.Controls.MaterialButton();
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
        // dgvAutores
        // 
        dgvAutores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvAutores.BackgroundColor = Color.White;
        dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAutores.Location = new Point(25, 145);
        dgvAutores.Name = "dgvAutores";
        dgvAutores.Size = new Size(1774, 808);
        dgvAutores.TabIndex = 2;
        // 
        // btnAuCrear
        // 
        btnAuCrear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        btnAuCrear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnAuCrear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnAuCrear.Depth = 0;
        btnAuCrear.HighEmphasis = true;
        btnAuCrear.Icon = null;
        btnAuCrear.Location = new Point(1678, 42);
        btnAuCrear.Margin = new Padding(4, 6, 4, 6);
        btnAuCrear.MouseState = MaterialSkin.MouseState.HOVER;
        btnAuCrear.Name = "btnAuCrear";
        btnAuCrear.NoAccentTextColor = Color.Empty;
        btnAuCrear.Size = new Size(121, 36);
        btnAuCrear.TabIndex = 5;
        btnAuCrear.Text = "Nuevo Autor";
        btnAuCrear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnAuCrear.UseAccentColor = false;
        btnAuCrear.UseVisualStyleBackColor = true;
        btnAuCrear.Click += btnAuCrear_Click;
        // 
        // UcAutores
        // 
        Controls.Add(btnRefrescar);
        Controls.Add(btnBuscar);
        Controls.Add(txtBuscar);
        Controls.Add(btnAuCrear);
        Controls.Add(dgvAutores);
        Controls.Add(lblDescripcion);
        Controls.Add(lblTitulo);
        Name = "UcAutores";
        Size = new Size(1824, 939);
        ((System.ComponentModel.ISupportInitialize)dgvAutores).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialLabel lblTitulo;
    private MaterialSkin.Controls.MaterialLabel lblDescripcion;
    private DataGridView dgvAutores;
    private MaterialSkin.Controls.MaterialButton btnAuCrear;
    private MaterialSkin.Controls.MaterialTextBox2 txtBuscar;
    private MaterialSkin.Controls.MaterialButton btnBuscar;
    private MaterialSkin.Controls.MaterialButton btnRefrescar;
}
