namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

partial class UcCategorias
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
        btnCaCrear = new MaterialSkin.Controls.MaterialButton();
        txtBuscar = new MaterialSkin.Controls.MaterialTextBox2();
        btnBuscar = new MaterialSkin.Controls.MaterialButton();
        btnRefrescar = new MaterialSkin.Controls.MaterialButton();
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
        lblTitulo.Size = new Size(117, 29);
        lblTitulo.TabIndex = 1;
        lblTitulo.Text = "Categorías";
        // 
        // lblDescripcion
        // 
        lblDescripcion.AutoSize = true;
        lblDescripcion.Depth = 0;
        lblDescripcion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        lblDescripcion.Location = new Point(26, 65);
        lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(221, 19);
        lblDescripcion.TabIndex = 0;
        lblDescripcion.Text = "Panel de gestión de categorías.";
        // 
        // txtBuscar
        // 
        txtBuscar.Location = new Point(25, 87);
        txtBuscar.Name = "txtBuscar";
        txtBuscar.Size = new Size(280, 48);
        txtBuscar.TabIndex = 4;
        // 
        // btnBuscar
        // 
        btnBuscar.Location = new Point(320, 93);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(105, 36);
        btnBuscar.TabIndex = 5;
        btnBuscar.Text = "Buscar";
        btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnBuscar.Click += btnBuscar_Click;
        // 
        // btnRefrescar
        // 
        btnRefrescar.Location = new Point(435, 93);
        btnRefrescar.Name = "btnRefrescar";
        btnRefrescar.Size = new Size(105, 36);
        btnRefrescar.TabIndex = 6;
        btnRefrescar.Text = "Refrescar";
        btnRefrescar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        btnRefrescar.Click += btnRefrescar_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView1.BackgroundColor = Color.White;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(25, 145);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(1774, 808);
        dataGridView1.TabIndex = 2;
        // 
        // btnCaCrear
        // 
        btnCaCrear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCaCrear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnCaCrear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnCaCrear.Depth = 0;
        btnCaCrear.HighEmphasis = true;
        btnCaCrear.Icon = null;
        btnCaCrear.Location = new Point(1647, 42);
        btnCaCrear.Margin = new Padding(4, 6, 4, 6);
        btnCaCrear.MouseState = MaterialSkin.MouseState.HOVER;
        btnCaCrear.Name = "btnCaCrear";
        btnCaCrear.NoAccentTextColor = Color.Empty;
        btnCaCrear.Size = new Size(153, 36);
        btnCaCrear.TabIndex = 3;
        btnCaCrear.Text = "Nueva Categoria";
        btnCaCrear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnCaCrear.UseAccentColor = false;
        btnCaCrear.UseVisualStyleBackColor = true;
        btnCaCrear.Click += btnCaCrear_Click;
        // 
        // UcCategorias
        // 
        BackColor = SystemColors.Control;
        Controls.Add(btnRefrescar);
        Controls.Add(btnBuscar);
        Controls.Add(txtBuscar);
        Controls.Add(btnCaCrear);
        Controls.Add(dataGridView1);
        Controls.Add(lblDescripcion);
        Controls.Add(lblTitulo);
        Name = "UcCategorias";
        Size = new Size(1824, 939);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialLabel lblTitulo;
    private MaterialSkin.Controls.MaterialLabel lblDescripcion;
    private DataGridView dataGridView1;
    private MaterialSkin.Controls.MaterialButton btnCaCrear;
    private MaterialSkin.Controls.MaterialTextBox2 txtBuscar;
    private MaterialSkin.Controls.MaterialButton btnBuscar;
    private MaterialSkin.Controls.MaterialButton btnRefrescar;
}
