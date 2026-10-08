namespace Sistema_Biblioteca;

partial class Form1
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        this.pnlFondoDegradado = new System.Windows.Forms.Panel();
        this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
        this.txtcorreo = new MaterialSkin.Controls.MaterialTextBox2();
        this.txtcontraseña = new MaterialSkin.Controls.MaterialTextBox2();
        this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.linkLabel1 = new System.Windows.Forms.LinkLabel();
        
        this.pnlFondoDegradado.SuspendLayout();
        this.materialCard1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // pnlFondoDegradado (Panel que dibujará el fondo de dos tonos)
        // 
        this.pnlFondoDegradado.Controls.Add(this.materialCard1);
        this.pnlFondoDegradado.Controls.Add(this.pictureBox1);
        this.pnlFondoDegradado.Controls.Add(this.linkLabel1);
        this.pnlFondoDegradado.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlFondoDegradado.Location = new System.Drawing.Point(3, 64);
        this.pnlFondoDegradado.Name = "pnlFondoDegradado";
        this.pnlFondoDegradado.Size = new System.Drawing.Size(662, 324);
        this.pnlFondoDegradado.TabIndex = 0;
        this.pnlFondoDegradado.AccessibleName = "pnlFondoDegradado";
        // 
        // materialCard1 (Tarjeta contenedora del Formulario de Ingreso)
        // 
        this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.materialCard1.Controls.Add(this.materialLabel1);
        this.materialCard1.Controls.Add(this.txtcorreo);
        this.materialCard1.Controls.Add(this.txtcontraseña);
        this.materialCard1.Controls.Add(this.materialButton1);
        this.materialCard1.Depth = 0;
        this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.materialCard1.Location = new System.Drawing.Point(26, 20);
        this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
        this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialCard1.Name = "materialCard1";
        this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
        this.materialCard1.Size = new System.Drawing.Size(350, 270);
        this.materialCard1.TabIndex = 1;
        // 
        // materialLabel1
        // 
        this.materialLabel1.AutoSize = true;
        this.materialLabel1.Depth = 0;
        this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
        this.materialLabel1.Location = new System.Drawing.Point(96, 22);
        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel1.Name = "materialLabel1";
        this.materialLabel1.Size = new System.Drawing.Size(130, 29);
        this.materialLabel1.TabIndex = 0;
        this.materialLabel1.Text = "Iniciar Sesión";
        // 
        // txtcorreo
        // 
        this.txtcorreo.AnimateReadOnly = false;
        this.txtcorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.txtcorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.txtcorreo.Depth = 0;
        this.txtcorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.txtcorreo.Hint = "Correo Electrónico";
        this.txtcorreo.LeadingIcon = null;
        this.txtcorreo.Location = new System.Drawing.Point(25, 65);
        this.txtcorreo.MaxLength = 32767;
        this.txtcorreo.MouseState = MaterialSkin.MouseState.OUT;
        this.txtcorreo.Name = "txtcorreo";
        this.txtcorreo.PasswordChar = '\0';
        this.txtcorreo.PrefixSuffixText = "";
        this.txtcorreo.ReadOnly = false;
        this.txtcorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.txtcorreo.SelectedText = "";
        this.txtcorreo.SelectionLength = 0;
        this.txtcorreo.SelectionStart = 0;
        this.txtcorreo.ShortcutsEnabled = true;
        this.txtcorreo.Size = new System.Drawing.Size(300, 48);
        this.txtcorreo.TabIndex = 1;
        this.txtcorreo.TabStop = false;
        this.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.txtcorreo.TrailingIcon = null;
        this.txtcorreo.UseSystemPasswordChar = false;
        this.txtcorreo.AccessibleName = "txtcorreo";
        // 
        // txtcontraseña
        // 
        this.txtcontraseña.AnimateReadOnly = false;
        this.txtcontraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.txtcontraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.txtcontraseña.Depth = 0;
        this.txtcontraseña.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.txtcontraseña.Hint = "Ingresa tu Contraseña";
        this.txtcontraseña.LeadingIcon = null;
        this.txtcontraseña.Location = new System.Drawing.Point(25, 128);
        this.txtcontraseña.MaxLength = 32767;
        this.txtcontraseña.MouseState = MaterialSkin.MouseState.OUT;
        this.txtcontraseña.Name = "txtcontraseña";
        this.txtcontraseña.PasswordChar = '\0';
        this.txtcontraseña.PrefixSuffixText = "";
        this.txtcontraseña.ReadOnly = false;
        this.txtcontraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.txtcontraseña.SelectedText = "";
        this.txtcontraseña.SelectionLength = 0;
        this.txtcontraseña.SelectionStart = 0;
        this.txtcontraseña.ShortcutsEnabled = true;
        this.txtcontraseña.Size = new System.Drawing.Size(300, 48);
        this.txtcontraseña.TabIndex = 2;
        this.txtcontraseña.TabStop = false;
        this.txtcontraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.txtcontraseña.TrailingIcon = null;
        this.txtcontraseña.UseSystemPasswordChar = true;
        // 
        // materialButton1
        // 
        this.materialButton1.AutoSize = false;
        this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.materialButton1.Depth = 0;
        this.materialButton1.HighEmphasis = true;
        this.materialButton1.Icon = null;
        this.materialButton1.Location = new System.Drawing.Point(25, 198);
        this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialButton1.Name = "materialButton1";
        this.materialButton1.Size = new System.Drawing.Size(300, 40);
        this.materialButton1.TabIndex = 3;
        this.materialButton1.Text = "INICIAR SESIÓN";
        this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.materialButton1.UseAccentColor = true; // Activa el rojo Accent que configuramos
        this.materialButton1.UseVisualStyleBackColor = true;
        this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
        // 
        // pictureBox1
        // 
        this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        this.pictureBox1.Location = new System.Drawing.Point(425, 50);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(180, 190);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pictureBox1.TabIndex = 2;
        this.pictureBox1.TabStop = false;
        // 
        // linkLabel1
        // 
        this.linkLabel1.AutoSize = true;
        this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
        this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
        this.linkLabel1.Location = new System.Drawing.Point(26, 298);
        this.linkLabel1.Name = "linkLabel1";
        this.linkLabel1.Size = new System.Drawing.Size(144, 15);
        this.linkLabel1.TabIndex = 3;
        this.linkLabel1.TabStop = true;
        this.linkLabel1.Text = "Contactar al Desarrollador";
        this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(668, 391);
        this.Controls.Add(this.pnlFondoDegradado);
        this.Name = "Form1";
        this.Text = "Sistema de Biblioteca - Colegio Tilburg";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.pnlFondoDegradado.ResumeLayout(false);
        this.pnlFondoDegradado.PerformLayout();
        this.materialCard1.ResumeLayout(false);
        this.materialCard1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlFondoDegradado;
    private MaterialSkin.Controls.MaterialCard materialCard1;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private MaterialSkin.Controls.MaterialTextBox2 txtcorreo;
    private MaterialSkin.Controls.MaterialTextBox2 txtcontraseña;
    private MaterialSkin.Controls.MaterialButton materialButton1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.LinkLabel linkLabel1;
}