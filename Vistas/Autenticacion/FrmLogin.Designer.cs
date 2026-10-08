namespace Sistema_Biblioteca.Vistas.Autenticacion;

partial class FrmLogin
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
        this.pnlFondo = new System.Windows.Forms.Panel();
        this.cardLogin = new MaterialSkin.Controls.MaterialCard();
        this.lblTituloLogin = new MaterialSkin.Controls.MaterialLabel();
        this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
        this.txtContrasena = new MaterialSkin.Controls.MaterialTextBox2();
        this.btnIngresar = new MaterialSkin.Controls.MaterialButton();
        this.picLogo = new System.Windows.Forms.PictureBox();
        this.lnkContacto = new System.Windows.Forms.LinkLabel();
        
        this.pnlFondo.SuspendLayout();
        this.cardLogin.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
        this.SuspendLayout();
        // 
        // pnlFondo (Panel que dibujará el fondo de dos tonos)
        // 
        this.pnlFondo.Controls.Add(this.cardLogin);
        this.pnlFondo.Controls.Add(this.picLogo);
        this.pnlFondo.Controls.Add(this.lnkContacto);
        this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlFondo.Location = new System.Drawing.Point(3, 64);
        this.pnlFondo.Name = "pnlFondo";
        this.pnlFondo.Size = new System.Drawing.Size(662, 324);
        this.pnlFondo.TabIndex = 0;
        this.pnlFondo.AccessibleName = "pnlFondo";
        // 
        // cardLogin (Tarjeta contenedora del formulario de inicio de sesión)
        // 
        this.cardLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.cardLogin.Controls.Add(this.lblTituloLogin);
        this.cardLogin.Controls.Add(this.txtCorreo);
        this.cardLogin.Controls.Add(this.txtContrasena);
        this.cardLogin.Controls.Add(this.btnIngresar);
        this.cardLogin.Depth = 0;
        this.cardLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.cardLogin.Location = new System.Drawing.Point(26, 20);
        this.cardLogin.Margin = new System.Windows.Forms.Padding(14);
        this.cardLogin.MouseState = MaterialSkin.MouseState.HOVER;
        this.cardLogin.Name = "cardLogin";
        this.cardLogin.Padding = new System.Windows.Forms.Padding(14);
        this.cardLogin.Size = new System.Drawing.Size(350, 270);
        this.cardLogin.TabIndex = 1;
        // 
        // lblTituloLogin
        // 
        this.lblTituloLogin.AutoSize = true;
        this.lblTituloLogin.Depth = 0;
        this.lblTituloLogin.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
        this.lblTituloLogin.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
        this.lblTituloLogin.Location = new System.Drawing.Point(96, 22);
        this.lblTituloLogin.MouseState = MaterialSkin.MouseState.HOVER;
        this.lblTituloLogin.Name = "lblTituloLogin";
        this.lblTituloLogin.Size = new System.Drawing.Size(130, 29);
        this.lblTituloLogin.TabIndex = 0;
        this.lblTituloLogin.Text = "Iniciar Sesión";
        // 
        // txtCorreo
        // 
        this.txtCorreo.AnimateReadOnly = false;
        this.txtCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.txtCorreo.Depth = 0;
        this.txtCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.txtCorreo.Hint = "Correo Electrónico";
        this.txtCorreo.LeadingIcon = null;
        this.txtCorreo.Location = new System.Drawing.Point(25, 65);
        this.txtCorreo.MaxLength = 32767;
        this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
        this.txtCorreo.Name = "txtCorreo";
        this.txtCorreo.PasswordChar = '\0';
        this.txtCorreo.PrefixSuffixText = "";
        this.txtCorreo.ReadOnly = false;
        this.txtCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.txtCorreo.SelectedText = "";
        this.txtCorreo.SelectionLength = 0;
        this.txtCorreo.SelectionStart = 0;
        this.txtCorreo.ShortcutsEnabled = true;
        this.txtCorreo.Size = new System.Drawing.Size(300, 48);
        this.txtCorreo.TabIndex = 1;
        this.txtCorreo.TabStop = false;
        this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.txtCorreo.TrailingIcon = null;
        this.txtCorreo.UseSystemPasswordChar = false;
        this.txtCorreo.AccessibleName = "txtCorreo";
        // 
        // txtContrasena
        // 
        this.txtContrasena.AnimateReadOnly = false;
        this.txtContrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.txtContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.txtContrasena.Depth = 0;
        this.txtContrasena.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.txtContrasena.Hint = "Ingresa tu Contraseña";
        this.txtContrasena.LeadingIcon = null;
        this.txtContrasena.Location = new System.Drawing.Point(25, 128);
        this.txtContrasena.MaxLength = 32767;
        this.txtContrasena.MouseState = MaterialSkin.MouseState.OUT;
        this.txtContrasena.Name = "txtContrasena";
        this.txtContrasena.PasswordChar = '\0';
        this.txtContrasena.PrefixSuffixText = "";
        this.txtContrasena.ReadOnly = false;
        this.txtContrasena.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.txtContrasena.SelectedText = "";
        this.txtContrasena.SelectionLength = 0;
        this.txtContrasena.SelectionStart = 0;
        this.txtContrasena.ShortcutsEnabled = true;
        this.txtContrasena.Size = new System.Drawing.Size(300, 48);
        this.txtContrasena.TabStop = false;
        this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.txtContrasena.TrailingIcon = null;
        this.txtContrasena.UseSystemPasswordChar = true;
        // 
        // btnIngresar
        // 
        this.btnIngresar.AutoSize = false;
        this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.btnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.btnIngresar.Depth = 0;
        this.btnIngresar.HighEmphasis = true;
        this.btnIngresar.Icon = null;
        this.btnIngresar.Location = new System.Drawing.Point(25, 198);
        this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
        this.btnIngresar.Name = "btnIngresar";
        this.btnIngresar.Size = new System.Drawing.Size(300, 40);
        this.btnIngresar.TabIndex = 3;
        this.btnIngresar.Text = "INICIAR SESIÓN";
        this.btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.btnIngresar.UseAccentColor = true; // Activa el rojo Accent que configuramos
        this.btnIngresar.UseVisualStyleBackColor = true;
        // Manejador actualizado para btnIngresar
        this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
        // 
        // picLogo
        // 
        this.picLogo.BackColor = System.Drawing.Color.Transparent;
        this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
        this.picLogo.Location = new System.Drawing.Point(425, 50);
        this.picLogo.Name = "picLogo";
        this.picLogo.Size = new System.Drawing.Size(180, 190);
        this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picLogo.TabIndex = 2;
        this.picLogo.TabStop = false;
        // 
        // lnkContacto
        // 
        this.lnkContacto.AutoSize = true;
        this.lnkContacto.BackColor = System.Drawing.Color.Transparent;
        this.lnkContacto.LinkColor = System.Drawing.Color.Blue;
        this.lnkContacto.Location = new System.Drawing.Point(26, 298);
        this.lnkContacto.Name = "lnkContacto";
        this.lnkContacto.Size = new System.Drawing.Size(144, 15);
        this.lnkContacto.TabIndex = 3;
        this.lnkContacto.TabStop = true;
        this.lnkContacto.Text = "Contactar al Desarrollador";
        // Manejador actualizado para lnkContacto
        this.lnkContacto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkContacto_LinkClicked);
        // 
        // FrmLogin
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(668, 391);
        this.Controls.Add(this.pnlFondo);
        this.Name = "FrmLogin";
        this.Text = "Sistema de Biblioteca - Colegio Tilburg";
        this.Load += new System.EventHandler(this.FrmLogin_Load);
        this.pnlFondo.ResumeLayout(false);
        this.pnlFondo.PerformLayout();
        this.cardLogin.ResumeLayout(false);
        this.cardLogin.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlFondo;
    private MaterialSkin.Controls.MaterialCard cardLogin;
    private MaterialSkin.Controls.MaterialLabel lblTituloLogin;
    private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
    private MaterialSkin.Controls.MaterialTextBox2 txtContrasena;
    private MaterialSkin.Controls.MaterialButton btnIngresar;
    private System.Windows.Forms.PictureBox picLogo;
    private System.Windows.Forms.LinkLabel lnkContacto;
}