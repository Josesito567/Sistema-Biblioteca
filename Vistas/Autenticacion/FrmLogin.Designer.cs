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
        pnlFondo = new Panel();
        cardLogin = new MaterialSkin.Controls.MaterialCard();
        lblTituloLogin = new MaterialSkin.Controls.MaterialLabel();
        txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
        txtContrasena = new MaterialSkin.Controls.MaterialTextBox2();
        btnIngresar = new MaterialSkin.Controls.MaterialButton();
        picLogo = new PictureBox();
        lnkContacto = new LinkLabel();
        pnlFondo.SuspendLayout();
        cardLogin.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        SuspendLayout();
        // 
        // pnlFondo
        // 
        pnlFondo.AccessibleName = "pnlFondo";
        pnlFondo.Controls.Add(cardLogin);
        pnlFondo.Controls.Add(picLogo);
        pnlFondo.Controls.Add(lnkContacto);
        pnlFondo.Dock = DockStyle.Fill;
        pnlFondo.Location = new Point(3, 64);
        pnlFondo.Name = "pnlFondo";
        pnlFondo.Size = new Size(662, 324);
        pnlFondo.TabIndex = 0;
        // 
        // cardLogin
        // 
        cardLogin.BackColor = Color.FromArgb(255, 255, 255);
        cardLogin.Controls.Add(lblTituloLogin);
        cardLogin.Controls.Add(txtCorreo);
        cardLogin.Controls.Add(txtContrasena);
        cardLogin.Controls.Add(btnIngresar);
        cardLogin.Depth = 0;
        cardLogin.ForeColor = Color.FromArgb(222, 0, 0, 0);
        cardLogin.Location = new Point(26, 20);
        cardLogin.Margin = new Padding(14);
        cardLogin.MouseState = MaterialSkin.MouseState.HOVER;
        cardLogin.Name = "cardLogin";
        cardLogin.Padding = new Padding(14);
        cardLogin.Size = new Size(350, 270);
        cardLogin.TabIndex = 1;
        // 
        // lblTituloLogin
        // 
        lblTituloLogin.AutoSize = true;
        lblTituloLogin.Depth = 0;
        lblTituloLogin.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
        lblTituloLogin.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
        lblTituloLogin.Location = new Point(96, 22);
        lblTituloLogin.MouseState = MaterialSkin.MouseState.HOVER;
        lblTituloLogin.Name = "lblTituloLogin";
        lblTituloLogin.Size = new Size(145, 29);
        lblTituloLogin.TabIndex = 0;
        lblTituloLogin.Text = "Iniciar Sesión";
        // 
        // txtCorreo
        // 
        txtCorreo.AccessibleName = "txtCorreo";
        txtCorreo.AnimateReadOnly = false;
        txtCorreo.BackgroundImageLayout = ImageLayout.None;
        txtCorreo.CharacterCasing = CharacterCasing.Normal;
        txtCorreo.Depth = 0;
        txtCorreo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        txtCorreo.HideSelection = true;
        txtCorreo.Hint = "Correo Electrónico";
        txtCorreo.LeadingIcon = null;
        txtCorreo.Location = new Point(25, 65);
        txtCorreo.MaxLength = 32767;
        txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
        txtCorreo.Name = "txtCorreo";
        txtCorreo.PasswordChar = '\0';
        txtCorreo.ReadOnly = false;
        txtCorreo.RightToLeft = RightToLeft.No;
        txtCorreo.SelectedText = "";
        txtCorreo.SelectionLength = 0;
        txtCorreo.SelectionStart = 0;
        txtCorreo.ShortcutsEnabled = true;
        txtCorreo.Size = new Size(300, 48);
        txtCorreo.TabIndex = 1;
        txtCorreo.TabStop = false;
        txtCorreo.TextAlign = HorizontalAlignment.Left;
        txtCorreo.TrailingIcon = null;
        txtCorreo.UseSystemPasswordChar = false;
        // 
        // txtContrasena
        // 
        txtContrasena.AnimateReadOnly = false;
        txtContrasena.BackgroundImageLayout = ImageLayout.None;
        txtContrasena.CharacterCasing = CharacterCasing.Normal;
        txtContrasena.Depth = 0;
        txtContrasena.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        txtContrasena.HideSelection = true;
        txtContrasena.Hint = "Ingresa tu Contraseña";
        txtContrasena.LeadingIcon = null;
        txtContrasena.Location = new Point(25, 128);
        txtContrasena.MaxLength = 32767;
        txtContrasena.MouseState = MaterialSkin.MouseState.OUT;
        txtContrasena.Name = "txtContrasena";
        txtContrasena.PasswordChar = '●';
        txtContrasena.ReadOnly = false;
        txtContrasena.RightToLeft = RightToLeft.No;
        txtContrasena.SelectedText = "";
        txtContrasena.SelectionLength = 0;
        txtContrasena.SelectionStart = 0;
        txtContrasena.ShortcutsEnabled = true;
        txtContrasena.Size = new Size(300, 48);
        txtContrasena.TabIndex = 2;
        txtContrasena.TabStop = false;
        txtContrasena.TextAlign = HorizontalAlignment.Left;
        txtContrasena.TrailingIcon = null;
        txtContrasena.UseSystemPasswordChar = true;
        txtContrasena.Click += txtContrasena_Click;
        // 
        // btnIngresar
        // 
        btnIngresar.AutoSize = false;
        btnIngresar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnIngresar.Depth = 0;
        btnIngresar.HighEmphasis = true;
        btnIngresar.Icon = null;
        btnIngresar.Location = new Point(25, 198);
        btnIngresar.Margin = new Padding(4, 6, 4, 6);
        btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
        btnIngresar.Name = "btnIngresar";
        btnIngresar.NoAccentTextColor = Color.Empty;
        btnIngresar.Size = new Size(300, 40);
        btnIngresar.TabIndex = 3;
        btnIngresar.Text = "INICIAR SESIÓN";
        btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnIngresar.UseAccentColor = true;
        btnIngresar.UseVisualStyleBackColor = true;
        btnIngresar.Click += btnIngresar_Click;
        // 
        // picLogo
        // 
        picLogo.BackColor = Color.Transparent;
        picLogo.Image = Properties.Resources.logo;
        picLogo.Location = new Point(425, 50);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(180, 190);
        picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        picLogo.TabIndex = 2;
        picLogo.TabStop = false;
        // 
        // lnkContacto
        // 
        lnkContacto.AutoSize = true;
        lnkContacto.BackColor = Color.Transparent;
        lnkContacto.LinkColor = Color.Blue;
        lnkContacto.Location = new Point(26, 298);
        lnkContacto.Name = "lnkContacto";
        lnkContacto.Size = new Size(144, 15);
        lnkContacto.TabIndex = 3;
        lnkContacto.TabStop = true;
        lnkContacto.Text = "Contactar al Desarrollador";
        lnkContacto.LinkClicked += lnkContacto_LinkClicked;
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(668, 391);
        Controls.Add(pnlFondo);
        Name = "FrmLogin";
        Text = "Sistema de Biblioteca - Colegio Tilburg";
        Load += FrmLogin_Load;
        pnlFondo.ResumeLayout(false);
        pnlFondo.PerformLayout();
        cardLogin.ResumeLayout(false);
        cardLogin.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        ResumeLayout(false);

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