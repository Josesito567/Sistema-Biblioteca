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
        this.btnInicio = new MaterialSkin.Controls.MaterialButton();
        this.btnEditoriales = new MaterialSkin.Controls.MaterialButton();
        this.btnAutores = new MaterialSkin.Controls.MaterialButton();
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
        this.pnlBarraLateral.Controls.Add(this.btnInicio);
        this.pnlBarraLateral.Controls.Add(this.btnEditoriales);
        this.pnlBarraLateral.Controls.Add(this.btnAutores);
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
        // BOTÓN INICIO
        // 
        this.btnInicio.AutoSize = false;
        this.btnInicio.Depth = 0;
        this.btnInicio.DrawShadows = true;
        this.btnInicio.HighEmphasis = true;
        this.btnInicio.Icon = null;
        this.btnInicio.Location = new System.Drawing.Point(12, 80);
        this.btnInicio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnInicio.Name = "btnInicio";
        this.btnInicio.Size = new System.Drawing.Size(196, 40);
        this.btnInicio.TabIndex = 1;
        this.btnInicio.Text = "Inicio";
        this.btnInicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.btnInicio.UseAccentColor = false;
        this.btnInicio.UseVisualStyleBackColor = true;

        // 
        // BOTÓN EDITORIALES
        // 
        this.btnEditoriales.AutoSize = false;
        this.btnEditoriales.Depth = 0;
        this.btnEditoriales.DrawShadows = true;
        this.btnEditoriales.HighEmphasis = true;
        this.btnEditoriales.Icon = null;
        this.btnEditoriales.Location = new System.Drawing.Point(12, 130);
        this.btnEditoriales.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.btnEditoriales.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnEditoriales.Name = "btnEditoriales";
        this.btnEditoriales.Size = new System.Drawing.Size(196, 40);
        this.btnEditoriales.TabIndex = 2;
        this.btnEditoriales.Text = "Editoriales";
        this.btnEditoriales.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        this.btnEditoriales.UseAccentColor = false;
        this.btnEditoriales.UseVisualStyleBackColor = true;

        // 
        // BOTÓN AUTORES
        // 
        this.btnAutores.AutoSize = false;
        this.btnAutores.Depth = 0;
        this.btnAutores.DrawShadows = true;
        this.btnAutores.HighEmphasis = true;
        this.btnAutores.Icon = null;
        this.btnAutores.Location = new System.Drawing.Point(12, 180);
        this.btnAutores.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.btnAutores.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnAutores.Name = "btnAutores";
        this.btnAutores.Size = new System.Drawing.Size(196, 40);
        this.btnAutores.TabIndex = 3;
        this.btnAutores.Text = "Autores";
        this.btnAutores.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        this.btnAutores.UseAccentColor = false;
        this.btnAutores.UseVisualStyleBackColor = true;

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
        this.btnCerrarSesion.TabIndex = 4;
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
    private MaterialSkin.Controls.MaterialButton btnInicio;
    private MaterialSkin.Controls.MaterialButton btnEditoriales;
    private MaterialSkin.Controls.MaterialButton btnAutores;
    private MaterialSkin.Controls.MaterialButton btnCerrarSesion;
    private System.Windows.Forms.Panel pnlContenido;
}