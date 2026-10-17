namespace Sistema_Biblioteca.Vistas.Modales;

partial class NuevaCategoria
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlCategoria;
    private MaterialSkin.Controls.MaterialLabel lblTitulo;
    private MaterialSkin.Controls.MaterialTextBox2 txtNombreCategoria;
    private MaterialSkin.Controls.MaterialTextBox2 txtDescripcionCategoria;
    private MaterialSkin.Controls.MaterialButton btnGuardarCategoria;

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
        pnlCategoria = new Panel();
        btnGuardarCategoria = new MaterialSkin.Controls.MaterialButton();
        txtDescripcionCategoria = new MaterialSkin.Controls.MaterialTextBox2();
        txtNombreCategoria = new MaterialSkin.Controls.MaterialTextBox2();
        lblTitulo = new MaterialSkin.Controls.MaterialLabel();
        pnlCategoria.SuspendLayout();
        SuspendLayout();
        // 
        // pnlCategoria
        // 
        pnlCategoria.AutoScroll = true;
        pnlCategoria.Controls.Add(btnGuardarCategoria);
        pnlCategoria.Controls.Add(txtDescripcionCategoria);
        pnlCategoria.Controls.Add(txtNombreCategoria);
        pnlCategoria.Controls.Add(lblTitulo);
        pnlCategoria.Dock = DockStyle.Fill;
        pnlCategoria.Location = new Point(3, 64);
        pnlCategoria.Name = "pnlCategoria";
        pnlCategoria.Padding = new Padding(20);
        pnlCategoria.Size = new Size(462, 455);
        pnlCategoria.TabIndex = 0;
        // 
        // btnGuardarCategoria
        // 
        btnGuardarCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        btnGuardarCategoria.AutoSize = false;
        btnGuardarCategoria.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnGuardarCategoria.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnGuardarCategoria.Depth = 0;
        btnGuardarCategoria.HighEmphasis = true;
        btnGuardarCategoria.Icon = null;
        btnGuardarCategoria.Location = new Point(20, 327);
        btnGuardarCategoria.Margin = new Padding(4, 6, 4, 6);
        btnGuardarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
        btnGuardarCategoria.Name = "btnGuardarCategoria";
        btnGuardarCategoria.NoAccentTextColor = Color.Empty;
        btnGuardarCategoria.Size = new Size(418, 40);
        btnGuardarCategoria.TabIndex = 3;
        btnGuardarCategoria.Text = "Guardar categoría";
        btnGuardarCategoria.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnGuardarCategoria.UseAccentColor = false;
        btnGuardarCategoria.UseVisualStyleBackColor = true;
        btnGuardarCategoria.Click += btnGuardarCategoria_Click;
        // 
        // txtDescripcionCategoria
        // 
        txtDescripcionCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtDescripcionCategoria.AnimateReadOnly = false;
        txtDescripcionCategoria.BackgroundImageLayout = ImageLayout.None;
        txtDescripcionCategoria.CharacterCasing = CharacterCasing.Normal;
        txtDescripcionCategoria.Depth = 0;
        txtDescripcionCategoria.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        txtDescripcionCategoria.HideSelection = true;
        txtDescripcionCategoria.Hint = "Descripción";
        txtDescripcionCategoria.LeadingIcon = null;
        txtDescripcionCategoria.Location = new Point(20, 159);
        txtDescripcionCategoria.MaxLength = 32767;
        txtDescripcionCategoria.MouseState = MaterialSkin.MouseState.OUT;
        txtDescripcionCategoria.Name = "txtDescripcionCategoria";
        txtDescripcionCategoria.PasswordChar = '\0';
        txtDescripcionCategoria.PrefixSuffixText = null;
        txtDescripcionCategoria.ReadOnly = false;
        txtDescripcionCategoria.RightToLeft = RightToLeft.No;
        txtDescripcionCategoria.SelectedText = "";
        txtDescripcionCategoria.SelectionLength = 0;
        txtDescripcionCategoria.SelectionStart = 0;
        txtDescripcionCategoria.ShortcutsEnabled = true;
        txtDescripcionCategoria.Size = new Size(419, 48);
        txtDescripcionCategoria.TabIndex = 2;
        txtDescripcionCategoria.TabStop = false;
        txtDescripcionCategoria.TextAlign = HorizontalAlignment.Left;
        txtDescripcionCategoria.TrailingIcon = null;
        txtDescripcionCategoria.UseSystemPasswordChar = false;
        // 
        // txtNombreCategoria
        // 
        txtNombreCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtNombreCategoria.AnimateReadOnly = false;
        txtNombreCategoria.BackgroundImageLayout = ImageLayout.None;
        txtNombreCategoria.CharacterCasing = CharacterCasing.Normal;
        txtNombreCategoria.Depth = 0;
        txtNombreCategoria.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        txtNombreCategoria.HideSelection = true;
        txtNombreCategoria.Hint = "Nombre de la categoría";
        txtNombreCategoria.LeadingIcon = null;
        txtNombreCategoria.Location = new Point(20, 70);
        txtNombreCategoria.MaxLength = 32767;
        txtNombreCategoria.MouseState = MaterialSkin.MouseState.OUT;
        txtNombreCategoria.Name = "txtNombreCategoria";
        txtNombreCategoria.PasswordChar = '\0';
        txtNombreCategoria.PrefixSuffixText = null;
        txtNombreCategoria.ReadOnly = false;
        txtNombreCategoria.RightToLeft = RightToLeft.No;
        txtNombreCategoria.SelectedText = "";
        txtNombreCategoria.SelectionLength = 0;
        txtNombreCategoria.SelectionStart = 0;
        txtNombreCategoria.ShortcutsEnabled = true;
        txtNombreCategoria.Size = new Size(419, 48);
        txtNombreCategoria.TabIndex = 1;
        txtNombreCategoria.TabStop = false;
        txtNombreCategoria.TextAlign = HorizontalAlignment.Left;
        txtNombreCategoria.TrailingIcon = null;
        txtNombreCategoria.UseSystemPasswordChar = false;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Depth = 0;
        lblTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
        lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
        lblTitulo.Location = new Point(20, 20);
        lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(176, 29);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Nueva categoría";
        // 
        // NuevaCategoria
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(468, 522);
        Controls.Add(pnlCategoria);
        MinimumSize = new Size(360, 250);
        Name = "NuevaCategoria";
        Text = "Nueva categoría";
        Load += NuevaCategoria_Load;
        pnlCategoria.ResumeLayout(false);
        pnlCategoria.PerformLayout();
        ResumeLayout(false);
    }
}
