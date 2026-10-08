namespace Sistema_Biblioteca.home.views;

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
        this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
        this.lblSubtitulo = new MaterialSkin.Controls.MaterialLabel();
        this.SuspendLayout();

        // 
        // lblTitulo
        // 
        this.lblTitulo.AutoSize = true;
        this.lblTitulo.Depth = 0;
        this.lblTitulo.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
        this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
        this.lblTitulo.Location = new System.Drawing.Point(25, 25);
        this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(262, 29);
        this.lblTitulo.TabIndex = 0;
        this.lblTitulo.Text = "Catálogo General de Libros";

        // 
        // lblSubtitulo
        // 
        this.lblSubtitulo.AutoSize = true;
        this.lblSubtitulo.Depth = 0;
        this.lblSubtitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.lblSubtitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
        this.lblSubtitulo.Location = new System.Drawing.Point(26, 60);
        this.lblSubtitulo.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblSubtitulo.Name = "lblSubtitulo";
        this.lblSubtitulo.Size = new System.Drawing.Size(325, 19);
        this.lblSubtitulo.TabIndex = 1;
        this.lblSubtitulo.Text = "Gestión de inventario y consulta de ejemplares";

        // 
        // UcLibros
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.lblSubtitulo);
        this.Controls.Add(this.lblTitulo);
        this.Name = "UcLibros";
        this.Size = new System.Drawing.Size(700, 500);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private MaterialSkin.Controls.MaterialLabel lblTitulo;
    private MaterialSkin.Controls.MaterialLabel lblSubtitulo;
}