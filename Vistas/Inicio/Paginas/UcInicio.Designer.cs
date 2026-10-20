namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

partial class UcInicio
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        } base.Dispose(disposing);
    }

    #region Component Designer generated code

    private void InitializeComponent()
    {
        pnlNavegacionLibros = new Panel();
        btnEditoriales = new MaterialSkin.Controls.MaterialButton();
        btnCategorias = new MaterialSkin.Controls.MaterialButton();
        btnLibros = new MaterialSkin.Controls.MaterialButton();
        btnAutores = new MaterialSkin.Controls.MaterialButton();
        pnlContenidoLibros = new Panel();
        pnlNavegacionLibros.SuspendLayout();
        SuspendLayout();
        // 
        // pnlNavegacionLibros
        // 
        pnlNavegacionLibros.Controls.Add(btnEditoriales);
        pnlNavegacionLibros.Controls.Add(btnCategorias);
        pnlNavegacionLibros.Controls.Add(btnLibros);
        pnlNavegacionLibros.Controls.Add(btnAutores);
        pnlNavegacionLibros.Dock = DockStyle.Top;
        pnlNavegacionLibros.Location = new Point(0, 0);
        pnlNavegacionLibros.Name = "pnlNavegacionLibros";
        pnlNavegacionLibros.Size = new Size(1418, 52);
        pnlNavegacionLibros.TabIndex = 0;
        // 
        // btnEditoriales
        // 
        btnEditoriales.AutoSize = false;
        btnEditoriales.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnEditoriales.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnEditoriales.Depth = 0;
        btnEditoriales.HighEmphasis = true;
        btnEditoriales.Icon = null;
        btnEditoriales.Location = new Point(12, 6);
        btnEditoriales.Margin = new Padding(4, 6, 4, 6);
        btnEditoriales.MouseState = MaterialSkin.MouseState.HOVER;
        btnEditoriales.Name = "btnEditoriales";
        btnEditoriales.NoAccentTextColor = Color.Empty;
        btnEditoriales.Size = new Size(145, 40);
        btnEditoriales.TabIndex = 0;
        btnEditoriales.Text = "Editoriales";
        btnEditoriales.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        btnEditoriales.UseAccentColor = false;
        btnEditoriales.UseVisualStyleBackColor = true;
        // 
        // btnCategorias
        // 
        btnCategorias.AutoSize = false;
        btnCategorias.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnCategorias.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnCategorias.Depth = 0;
        btnCategorias.HighEmphasis = true;
        btnCategorias.Icon = null;
        btnCategorias.Location = new Point(164, 6);
        btnCategorias.Margin = new Padding(4, 6, 4, 6);
        btnCategorias.MouseState = MaterialSkin.MouseState.HOVER;
        btnCategorias.Name = "btnCategorias";
        btnCategorias.NoAccentTextColor = Color.Empty;
        btnCategorias.Size = new Size(145, 40);
        btnCategorias.TabIndex = 1;
        btnCategorias.Text = "Categorías";
        btnCategorias.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        btnCategorias.UseAccentColor = false;
        btnCategorias.UseVisualStyleBackColor = true;
        // 
        // btnLibros
        // 
        btnLibros.AutoSize = false;
        btnLibros.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnLibros.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnLibros.Depth = 0;
        btnLibros.HighEmphasis = true;
        btnLibros.Icon = null;
        btnLibros.Location = new Point(316, 6);
        btnLibros.Margin = new Padding(4, 6, 4, 6);
        btnLibros.MouseState = MaterialSkin.MouseState.HOVER;
        btnLibros.Name = "btnLibros";
        btnLibros.NoAccentTextColor = Color.Empty;
        btnLibros.Size = new Size(145, 40);
        btnLibros.TabIndex = 2;
        btnLibros.Text = "Libros";
        btnLibros.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnLibros.UseAccentColor = false;
        btnLibros.UseVisualStyleBackColor = true;
        // 
        // btnAutores
        // 
        btnAutores.AutoSize = false;
        btnAutores.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnAutores.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnAutores.Depth = 0;
        btnAutores.HighEmphasis = true;
        btnAutores.Icon = null;
        btnAutores.Location = new Point(468, 6);
        btnAutores.Margin = new Padding(4, 6, 4, 6);
        btnAutores.MouseState = MaterialSkin.MouseState.HOVER;
        btnAutores.Name = "btnAutores";
        btnAutores.NoAccentTextColor = Color.Empty;
        btnAutores.Size = new Size(145, 40);
        btnAutores.TabIndex = 3;
        btnAutores.Text = "Autores";
        btnAutores.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        btnAutores.UseAccentColor = false;
        btnAutores.UseVisualStyleBackColor = true;
        btnAutores.Click += btnAutores_Click;
        // 
        // pnlContenidoLibros
        // 
        pnlContenidoLibros.BackColor = Color.White;
        pnlContenidoLibros.Dock = DockStyle.Fill;
        pnlContenidoLibros.Location = new Point(0, 52);
        pnlContenidoLibros.Name = "pnlContenidoLibros";
        pnlContenidoLibros.Size = new Size(1418, 727);
        pnlContenidoLibros.TabIndex = 1;
        // 
        // UcLibros
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(pnlContenidoLibros);
        Controls.Add(pnlNavegacionLibros);
        Name = "UcLibros";
        Size = new Size(1418, 779);
        pnlNavegacionLibros.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlNavegacionLibros;
    private MaterialSkin.Controls.MaterialButton btnEditoriales;
    private MaterialSkin.Controls.MaterialButton btnCategorias;
    private MaterialSkin.Controls.MaterialButton btnLibros;
    private MaterialSkin.Controls.MaterialButton btnAutores;
    private System.Windows.Forms.Panel pnlContenidoLibros;
}