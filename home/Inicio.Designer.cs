namespace Sistema_Biblioteca.home;

partial class Inicio
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
        this.pnlSidebar = new System.Windows.Forms.Panel();
        this.lblMenuTitulo = new MaterialSkin.Controls.MaterialLabel();
        this.lblMenuSubtitulo = new MaterialSkin.Controls.MaterialLabel();
        this.btnHome = new MaterialSkin.Controls.MaterialButton();
        this.btnPublisher = new MaterialSkin.Controls.MaterialButton();
        this.btnAuthors = new MaterialSkin.Controls.MaterialButton();
        this.btnCerrarSesion = new MaterialSkin.Controls.MaterialButton();
        this.pnlContenido = new System.Windows.Forms.Panel();
        
        this.pnlSidebar.SuspendLayout();
        this.SuspendLayout();

        // 
        // BARRA LATERAL (pnlSidebar)
        // 
        this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
        this.pnlSidebar.Controls.Add(this.lblMenuTitulo);
        this.pnlSidebar.Controls.Add(this.lblMenuSubtitulo);
        this.pnlSidebar.Controls.Add(this.btnHome);
        this.pnlSidebar.Controls.Add(this.btnPublisher);
        this.pnlSidebar.Controls.Add(this.btnAuthors);
        this.pnlSidebar.Controls.Add(this.btnCerrarSesion);
        this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        this.pnlSidebar.Location = new System.Drawing.Point(3, 64);
        this.pnlSidebar.Name = "pnlSidebar";
        this.pnlSidebar.Size = new System.Drawing.Size(220, 600);
        this.pnlSidebar.TabIndex = 0;

        // 
        // TÍTULO DEL MENÚ
        // 
        this.lblMenuTitulo.AutoSize = true;
        this.lblMenuTitulo.Depth = 0;
        this.lblMenuTitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
        this.lblMenuTitulo.HighEmphasis = true;
        this.lblMenuTitulo.Location = new System.Drawing.Point(16, 20);
        this.lblMenuTitulo.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblMenuTitulo.Name = "lblMenuTitulo";
        this.lblMenuTitulo.Size = new System.Drawing.Size(150, 19);
        this.lblMenuTitulo.Text = "COLEGIO TILBURG";

        // 
        // SUBTÍTULO DEL MENÚ
        // 
        this.lblMenuSubtitulo.AutoSize = true;
        this.lblMenuSubtitulo.Depth = 0;
        this.lblMenuSubtitulo.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.lblMenuSubtitulo.Location = new System.Drawing.Point(16, 42);
        this.lblMenuSubtitulo.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblMenuSubtitulo.Name = "lblMenuSubtitulo";
        this.lblMenuSubtitulo.Size = new System.Drawing.Size(130, 14);
        this.lblMenuSubtitulo.Text = "Gestión de Biblioteca";

        // 
        // BOTÓN HOME
        // 
        this.btnHome.AutoSize = false;
        this.btnHome.Depth = 0;
        this.btnHome.DrawShadows = true;
        this.btnHome.HighEmphasis = true;
        this.btnHome.Icon = null;
        this.btnHome.Location = new System.Drawing.Point(12, 80);
        this.btnHome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.btnHome.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnHome.Name = "btnHome";
        this.btnHome.Size = new System.Drawing.Size(196, 40);
        this.btnHome.TabIndex = 1;
        this.btnHome.Text = "Home";
        this.btnHome.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.btnHome.UseAccentColor = false;
        this.btnHome.UseVisualStyleBackColor = true;

        // 
        // BOTÓN PUBLISHER
        // 
        this.btnPublisher.AutoSize = false;
        this.btnPublisher.Depth = 0;
        this.btnPublisher.DrawShadows = true;
        this.btnPublisher.HighEmphasis = true;
        this.btnPublisher.Icon = null;
        this.btnPublisher.Location = new System.Drawing.Point(12, 130);
        this.btnPublisher.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.btnPublisher.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnPublisher.Name = "btnPublisher";
        this.btnPublisher.Size = new System.Drawing.Size(196, 40);
        this.btnPublisher.TabIndex = 2;
        this.btnPublisher.Text = "Publisher";
        this.btnPublisher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        this.btnPublisher.UseAccentColor = false;
        this.btnPublisher.UseVisualStyleBackColor = true;

        // 
        // BOTÓN AUTHORS
        // 
        this.btnAuthors.AutoSize = false;
        this.btnAuthors.Depth = 0;
        this.btnAuthors.DrawShadows = true;
        this.btnAuthors.HighEmphasis = true;
        this.btnAuthors.Icon = null;
        this.btnAuthors.Location = new System.Drawing.Point(12, 180);
        this.btnAuthors.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.btnAuthors.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnAuthors.Name = "btnAuthors";
        this.btnAuthors.Size = new System.Drawing.Size(196, 40);
        this.btnAuthors.TabIndex = 3;
        this.btnAuthors.Text = "Authors";
        this.btnAuthors.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        this.btnAuthors.UseAccentColor = false;
        this.btnAuthors.UseVisualStyleBackColor = true;

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
        this.Controls.Add(this.pnlSidebar);
        this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_56;
        this.Name = "Inicio";
        this.Text = "Panel de Control";
        this.pnlSidebar.ResumeLayout(false);
        this.pnlSidebar.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlSidebar;
    private MaterialSkin.Controls.MaterialLabel lblMenuTitulo;
    private MaterialSkin.Controls.MaterialLabel lblMenuSubtitulo;
    private MaterialSkin.Controls.MaterialButton btnHome;
    private MaterialSkin.Controls.MaterialButton btnPublisher;
    private MaterialSkin.Controls.MaterialButton btnAuthors;
    private MaterialSkin.Controls.MaterialButton btnCerrarSesion;
    private System.Windows.Forms.Panel pnlContenido;
}