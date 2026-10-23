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
        btnEdCrear = new MaterialSkin.Controls.MaterialButton();
        txtBuscar = new MaterialSkin.Controls.MaterialTextBox2();
        btnBuscar = new MaterialSkin.Controls.MaterialButton();
        btnRefrescar = new MaterialSkin.Controls.MaterialButton();
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
        dgvEditoriales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvEditoriales.BackgroundColor = Color.White;
        dgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvEditoriales.Location = new Point(25, 145);
        dgvEditoriales.Name = "dgvEditoriales";
        dgvEditoriales.Size = new Size(1202, 416);
        dgvEditoriales.TabIndex = 2;
        dgvEditoriales.CellContentClick += dgvEditoriales_CellContentClick;
        // 
        // btnEdCrear
        // 
        btnEdCrear.AccessibleDescription = "para crear una nueva editorial";
        btnEdCrear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        btnEdCrear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnEdCrear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnEdCrear.Depth = 0;
        btnEdCrear.HighEmphasis = true;
        btnEdCrear.Icon = null;
        btnEdCrear.Location = new Point(1064, 42);
        btnEdCrear.Margin = new Padding(4, 6, 4, 6);
        btnEdCrear.MouseState = MaterialSkin.MouseState.HOVER;
        btnEdCrear.Name = "btnEdCrear";
        btnEdCrear.NoAccentTextColor = Color.Empty;
        btnEdCrear.Size = new Size(145, 36);
        btnEdCrear.TabIndex = 3;
        btnEdCrear.Text = "Nueva Editorial";
        btnEdCrear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnEdCrear.UseAccentColor = false;
        btnEdCrear.UseVisualStyleBackColor = true;
        btnEdCrear.Click += btnEdCrear_Click;
        // 
        // txtBuscar
        // 
        txtBuscar.AnimateReadOnly = false;
        txtBuscar.BackgroundImageLayout = ImageLayout.None;
        txtBuscar.CharacterCasing = CharacterCasing.Normal;
        txtBuscar.Depth = 0;
        txtBuscar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        txtBuscar.HideSelection = true;
        txtBuscar.LeadingIcon = null;
        txtBuscar.Location = new Point(25, 87);
        txtBuscar.MaxLength = 32767;
        txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
        txtBuscar.Name = "txtBuscar";
        txtBuscar.PasswordChar = '\0';
        txtBuscar.PrefixSuffixText = null;
        txtBuscar.ReadOnly = false;
        txtBuscar.RightToLeft = RightToLeft.No;
        txtBuscar.SelectedText = "";
        txtBuscar.SelectionLength = 0;
        txtBuscar.SelectionStart = 0;
        txtBuscar.ShortcutsEnabled = true;
        txtBuscar.Size = new Size(280, 48);
        txtBuscar.TabIndex = 4;
        txtBuscar.TabStop = false;
        txtBuscar.TextAlign = HorizontalAlignment.Left;
        txtBuscar.TrailingIcon = null;
        txtBuscar.UseSystemPasswordChar = false;
        // 
        // btnBuscar
        // 
        btnBuscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnBuscar.Depth = 0;
        btnBuscar.HighEmphasis = true;
        btnBuscar.Icon = null;
        btnBuscar.Location = new Point(320, 93);
        btnBuscar.Margin = new Padding(4, 6, 4, 6);
        btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
        btnBuscar.Name = "btnBuscar";
        btnBuscar.NoAccentTextColor = Color.Empty;
        btnBuscar.Size = new Size(77, 36);
        btnBuscar.TabIndex = 5;
        btnBuscar.Text = "Buscar";
        btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnBuscar.UseAccentColor = false;
        btnBuscar.Click += btnBuscar_Click;
        // 
        // btnRefrescar
        // 
        btnRefrescar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnRefrescar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnRefrescar.Depth = 0;
        btnRefrescar.HighEmphasis = true;
        btnRefrescar.Icon = null;
        btnRefrescar.Location = new Point(435, 93);
        btnRefrescar.Margin = new Padding(4, 6, 4, 6);
        btnRefrescar.MouseState = MaterialSkin.MouseState.HOVER;
        btnRefrescar.Name = "btnRefrescar";
        btnRefrescar.NoAccentTextColor = Color.Empty;
        btnRefrescar.Size = new Size(102, 36);
        btnRefrescar.TabIndex = 6;
        btnRefrescar.Text = "Refrescar";
        btnRefrescar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        btnRefrescar.UseAccentColor = false;
        btnRefrescar.Click += btnRefrescar_Click;
        // 
        // UcEditoriales
        // 
        Controls.Add(btnRefrescar);
        Controls.Add(btnBuscar);
        Controls.Add(txtBuscar);
        Controls.Add(btnEdCrear);
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
    private MaterialSkin.Controls.MaterialButton btnEdCrear;
    private MaterialSkin.Controls.MaterialTextBox2 txtBuscar;
    private MaterialSkin.Controls.MaterialButton btnBuscar;
    private MaterialSkin.Controls.MaterialButton btnRefrescar;
}
