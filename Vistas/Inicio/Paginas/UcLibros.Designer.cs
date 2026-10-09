namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

partial class UcLibros
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
        this.pnlNavegacionLibros = new System.Windows.Forms.Panel();
        this.btnEditoriales = new MaterialSkin.Controls.MaterialButton();
        this.btnCategorias = new MaterialSkin.Controls.MaterialButton();
        this.btnLibros = new MaterialSkin.Controls.MaterialButton();
        this.btnAutores = new MaterialSkin.Controls.MaterialButton();
        this.pnlContenidoLibros = new System.Windows.Forms.Panel();
        this.pnlNavegacionLibros.SuspendLayout();
        this.SuspendLayout();

        // 
        // pnlNavegacionLibros
        // 
        this.pnlNavegacionLibros.Controls.Add(this.btnEditoriales);
        this.pnlNavegacionLibros.Controls.Add(this.btnCategorias);
        this.pnlNavegacionLibros.Controls.Add(this.btnLibros);
        this.pnlNavegacionLibros.Controls.Add(this.btnAutores);
        this.pnlNavegacionLibros.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlNavegacionLibros.Location = new System.Drawing.Point(0, 0);
        this.pnlNavegacionLibros.Name = "pnlNavegacionLibros";
        this.pnlNavegacionLibros.Size = new System.Drawing.Size(700, 52);
        this.pnlNavegacionLibros.TabIndex = 0;

        // 
        // botones de navegación interna
        // 
        this.btnEditoriales.AutoSize = false;
        this.btnEditoriales.Location = new System.Drawing.Point(12, 6);
        this.btnEditoriales.Size = new System.Drawing.Size(145, 40);
        this.btnEditoriales.Text = "Editoriales";
        this.btnEditoriales.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        this.btnEditoriales.UseVisualStyleBackColor = true;

        this.btnCategorias.AutoSize = false;
        this.btnCategorias.Location = new System.Drawing.Point(164, 6);
        this.btnCategorias.Size = new System.Drawing.Size(145, 40);
        this.btnCategorias.Text = "Categorías";
        this.btnCategorias.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        this.btnCategorias.UseVisualStyleBackColor = true;

        this.btnLibros.AutoSize = false;
        this.btnLibros.Location = new System.Drawing.Point(316, 6);
        this.btnLibros.Size = new System.Drawing.Size(145, 40);
        this.btnLibros.Text = "Libros";
        this.btnLibros.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.btnLibros.UseVisualStyleBackColor = true;

        this.btnAutores.AutoSize = false;
        this.btnAutores.Location = new System.Drawing.Point(468, 6);
        this.btnAutores.Size = new System.Drawing.Size(145, 40);
        this.btnAutores.Text = "Autores";
        this.btnAutores.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        this.btnAutores.UseVisualStyleBackColor = true;

        // 
        // pnlContenidoLibros
        // 
        this.pnlContenidoLibros.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlContenidoLibros.Location = new System.Drawing.Point(0, 52);
        this.pnlContenidoLibros.Name = "pnlContenidoLibros";
        this.pnlContenidoLibros.Size = new System.Drawing.Size(700, 448);
        this.pnlContenidoLibros.TabIndex = 1;

        // 
        // UcLibros
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.pnlContenidoLibros);
        this.Controls.Add(this.pnlNavegacionLibros);
        this.Name = "UcLibros";
        this.Size = new System.Drawing.Size(700, 500);
        this.pnlNavegacionLibros.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlNavegacionLibros;
    private MaterialSkin.Controls.MaterialButton btnEditoriales;
    private MaterialSkin.Controls.MaterialButton btnCategorias;
    private MaterialSkin.Controls.MaterialButton btnLibros;
    private MaterialSkin.Controls.MaterialButton btnAutores;
    private System.Windows.Forms.Panel pnlContenidoLibros;
}