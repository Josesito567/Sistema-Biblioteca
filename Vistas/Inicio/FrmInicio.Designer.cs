namespace Sistema_Biblioteca.Vistas.Inicio;

partial class FrmInicio
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

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.pnlBarraLateral = new System.Windows.Forms.Panel();
        this.lblTituloMenu = new MaterialSkin.Controls.MaterialLabel();
        this.lblSubtituloMenu = new MaterialSkin.Controls.MaterialLabel();
        this.btnLibros = new MaterialSkin.Controls.MaterialButton();
        this.btnAyuda = new MaterialSkin.Controls.MaterialButton();
        this.btnCerrarSesion = new MaterialSkin.Controls.MaterialButton();
        this.pnlContenido = new System.Windows.Forms.Panel();
        
        this.pnlBarraLateral.SuspendLayout();
        this.SuspendLayout();

        // 
        // BARRA LATERAL (pnlBarraLateral)
        // 
        this.pnlBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
        this.pnlBarraLateral.Controls.Add(this.lblTituloMenu);
        this.pnlBarraLateral.Controls.Add(this.lblSubtituloMenu);
        this.pnlBarraLateral.Controls.Add(this.btnLibros);
        this.pnlBarraLateral.Controls.Add(this.btnAyuda);
        this.pnlBarraLateral.Controls.Add(this.btnCerrarSesion);
        this.pnlBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
        this.pnlBarraLateral.Location = new System.Drawing.Point(3, 64);
        this.pnlBarraLateral.Name = "pnlBarraLateral";
        this.pnlBarraLateral.Size = new System.Drawing.Size(220, 600);
        this.pnlBarraLateral.TabIndex = 0;

        // 
        // TÍTULO DEL MENÚ
        // 
        this.lblTituloMenu.AutoSize = true;
        this.lblTituloMenu.Depth = 0;
        this.lblTituloMenu.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
        this.lblTituloMenu.HighEmphasis = true;
        this.lblTituloMenu.Location = new System.Drawing.Point(16, 20);
        this.lblTituloMenu.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTituloMenu.Name = "lblTituloMenu";
        this.lblTituloMenu.Size = new System.Drawing.Size(150, 19);
        this.lblTituloMenu.Text = "COLEGIO TILBURG";

        // 
        // SUBTÍTULO DEL MENÚ
        // 
        this.lblSubtituloMenu.AutoSize = true;
        this.lblSubtituloMenu.Depth = 0;
        this.lblSubtituloMenu.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.lblSubtituloMenu.Location = new System.Drawing.Point(16, 42);
        this.lblSubtituloMenu.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblSubtituloMenu.Name = "lblSubtituloMenu";
        this.lblSubtituloMenu.Size = new System.Drawing.Size(130, 14);
        this.lblSubtituloMenu.Text = "Gestión de Biblioteca";

        // 
        // BOTÓN LIBROS
        // 
        this.btnLibros.AutoSize = false;
        this.btnLibros.Depth = 0;
        this.btnLibros.DrawShadows = true;
        this.btnLibros.HighEmphasis = true;
        this.btnLibros.Icon = null;
        this.btnLibros.Location = new System.Drawing.Point(12, 80);
        this.btnLibros.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.btnLibros.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnLibros.Name = "btnLibros";
        this.btnLibros.Size = new System.Drawing.Size(196, 40);
        this.btnLibros.TabIndex = 1;
        this.btnLibros.Text = "Libros";
        this.btnLibros.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.btnLibros.UseAccentColor = false;
        this.btnLibros.UseVisualStyleBackColor = true;

        // 
        // BOTÓN AYUDA
        // 
        this.btnAyuda.AutoSize = false;
        this.btnAyuda.Depth = 0;
        this.btnAyuda.DrawShadows = true;
        this.btnAyuda.HighEmphasis = true;
        this.btnAyuda.Icon = null;
        this.btnAyuda.Location = new System.Drawing.Point(12, 130);
        this.btnAyuda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.btnAyuda.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnAyuda.Name = "btnAyuda";
        this.btnAyuda.Size = new System.Drawing.Size(196, 40);
        this.btnAyuda.TabIndex = 2;
        this.btnAyuda.Text = "Ayuda";
        this.btnAyuda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        this.btnAyuda.UseAccentColor = false;
        this.btnAyuda.UseVisualStyleBackColor = true;

        // 
        // BOTÓN CERRAR SESIÓN
        // 
        this.btnCerrarSesion.AutoSize = false;
        this.btnCerrarSesion.Depth = 0;
        this.btnCerrarSesion.DrawShadows = true;
        this.btnCerrarSesion.HighEmphasis = true;
        this.btnCerrarSesion.Icon = null;
        this.btnCerrarSesion.Location = new System.Drawing.Point(12, 540);
        this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnCerrarSesion.Name = "btnCerrarSesion";
        this.btnCerrarSesion.Size = new System.Drawing.Size(196, 40);
        this.btnCerrarSesion.TabIndex = 3;
        this.btnCerrarSesion.Text = "Cerrar Sesión";
        this.btnCerrarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
        this.btnCerrarSesion.UseAccentColor = true;
        this.btnCerrarSesion.UseVisualStyleBackColor = true;

        // 
        // PANEL CONTENEDOR PRINCIPAL (pnlContenido)
        // 
        this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlContenido.Location = new System.Drawing.Point(223, 64);
        this.pnlContenido.Name = "pnlContenido";
        this.pnlContenido.Size = new System.Drawing.Size(774, 600);
        this.pnlContenido.TabIndex = 1;

        // 
        // FORMULARIO INICIO
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1000, 667);
        this.Controls.Add(this.pnlContenido);
        this.Controls.Add(this.pnlBarraLateral);
        this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_56;
        this.Name = "Inicio";
        this.Text = "Panel de Control";
        this.pnlBarraLateral.ResumeLayout(false);
        this.pnlBarraLateral.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlBarraLateral;
    private MaterialSkin.Controls.MaterialLabel lblTituloMenu;
    private MaterialSkin.Controls.MaterialLabel lblSubtituloMenu;
    private MaterialSkin.Controls.MaterialButton btnLibros;
    private MaterialSkin.Controls.MaterialButton btnAyuda;
    private MaterialSkin.Controls.MaterialButton btnCerrarSesion;
    private System.Windows.Forms.Panel pnlContenido;
}