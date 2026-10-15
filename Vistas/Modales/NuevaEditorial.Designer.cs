namespace Sistema_Biblioteca.Vistas.Modales
{
    partial class NuevaEditorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlNuevaEditorial = new Panel();
            txtNombreEditorial = new MaterialSkin.Controls.MaterialTextBox2();
            txtDireccionEditorial = new MaterialSkin.Controls.MaterialTextBox2();
            txtEmailEditorial = new MaterialSkin.Controls.MaterialTextBox2();
            txtTelefonoEditorial = new MaterialSkin.Controls.MaterialTextBox2();
            txtCiudadEditorial = new MaterialSkin.Controls.MaterialTextBox2();
            dtpRegistroEditorial = new DateTimePicker();
            btnGuardarEditorial = new MaterialSkin.Controls.MaterialButton();
            pnlNuevaEditorial.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNuevaEditorial
            // 
            pnlNuevaEditorial.AccessibleName = "pnlNuevaEditorial";
            pnlNuevaEditorial.Controls.Add(btnGuardarEditorial);
            pnlNuevaEditorial.Controls.Add(dtpRegistroEditorial);
            pnlNuevaEditorial.Controls.Add(txtCiudadEditorial);
            pnlNuevaEditorial.Controls.Add(txtTelefonoEditorial);
            pnlNuevaEditorial.Controls.Add(txtEmailEditorial);
            pnlNuevaEditorial.Controls.Add(txtDireccionEditorial);
            pnlNuevaEditorial.Controls.Add(txtNombreEditorial);
            pnlNuevaEditorial.Location = new Point(6, 67);
            pnlNuevaEditorial.Name = "pnlNuevaEditorial";
            pnlNuevaEditorial.Size = new Size(456, 449);
            pnlNuevaEditorial.TabIndex = 0;
            // 
            // txtNombreEditorial
            // 
            txtNombreEditorial.AccessibleName = "txtNombreEditorial";
            txtNombreEditorial.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreEditorial.AnimateReadOnly = false;
            txtNombreEditorial.BackgroundImageLayout = ImageLayout.None;
            txtNombreEditorial.CharacterCasing = CharacterCasing.Normal;
            txtNombreEditorial.Depth = 0;
            txtNombreEditorial.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreEditorial.HideSelection = true;
            txtNombreEditorial.Hint = "Nombre del Editorial";
            txtNombreEditorial.LeadingIcon = null;
            txtNombreEditorial.Location = new Point(24, 35);
            txtNombreEditorial.MaxLength = 32767;
            txtNombreEditorial.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreEditorial.Name = "txtNombreEditorial";
            txtNombreEditorial.PasswordChar = '\0';
            txtNombreEditorial.PrefixSuffixText = null;
            txtNombreEditorial.ReadOnly = false;
            txtNombreEditorial.RightToLeft = RightToLeft.No;
            txtNombreEditorial.SelectedText = "";
            txtNombreEditorial.SelectionLength = 0;
            txtNombreEditorial.SelectionStart = 0;
            txtNombreEditorial.ShortcutsEnabled = true;
            txtNombreEditorial.Size = new Size(406, 48);
            txtNombreEditorial.TabIndex = 0;
            txtNombreEditorial.TabStop = false;
            txtNombreEditorial.TextAlign = HorizontalAlignment.Left;
            txtNombreEditorial.TrailingIcon = null;
            txtNombreEditorial.UseSystemPasswordChar = false;
            // 
            // txtDireccionEditorial
            // 
            txtDireccionEditorial.AccessibleName = "txtDireccionEditorial";
            txtDireccionEditorial.AnimateReadOnly = false;
            txtDireccionEditorial.BackgroundImageLayout = ImageLayout.None;
            txtDireccionEditorial.CharacterCasing = CharacterCasing.Normal;
            txtDireccionEditorial.Depth = 0;
            txtDireccionEditorial.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDireccionEditorial.HideSelection = true;
            txtDireccionEditorial.Hint = "Dirección";
            txtDireccionEditorial.LeadingIcon = null;
            txtDireccionEditorial.Location = new Point(24, 89);
            txtDireccionEditorial.MaxLength = 32767;
            txtDireccionEditorial.MouseState = MaterialSkin.MouseState.OUT;
            txtDireccionEditorial.Name = "txtDireccionEditorial";
            txtDireccionEditorial.PasswordChar = '\0';
            txtDireccionEditorial.PrefixSuffixText = null;
            txtDireccionEditorial.ReadOnly = false;
            txtDireccionEditorial.RightToLeft = RightToLeft.No;
            txtDireccionEditorial.SelectedText = "";
            txtDireccionEditorial.SelectionLength = 0;
            txtDireccionEditorial.SelectionStart = 0;
            txtDireccionEditorial.ShortcutsEnabled = true;
            txtDireccionEditorial.Size = new Size(406, 48);
            txtDireccionEditorial.TabIndex = 1;
            txtDireccionEditorial.TabStop = false;
            txtDireccionEditorial.TextAlign = HorizontalAlignment.Left;
            txtDireccionEditorial.TrailingIcon = null;
            txtDireccionEditorial.UseSystemPasswordChar = false;
            // 
            // txtEmailEditorial
            // 
            txtEmailEditorial.AccessibleName = "txtEmailEditorial";
            txtEmailEditorial.AnimateReadOnly = false;
            txtEmailEditorial.BackgroundImageLayout = ImageLayout.None;
            txtEmailEditorial.CharacterCasing = CharacterCasing.Normal;
            txtEmailEditorial.Depth = 0;
            txtEmailEditorial.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmailEditorial.HideSelection = true;
            txtEmailEditorial.Hint = "Email";
            txtEmailEditorial.LeadingIcon = null;
            txtEmailEditorial.Location = new Point(24, 143);
            txtEmailEditorial.MaxLength = 32767;
            txtEmailEditorial.MouseState = MaterialSkin.MouseState.OUT;
            txtEmailEditorial.Name = "txtEmailEditorial";
            txtEmailEditorial.PasswordChar = '\0';
            txtEmailEditorial.PrefixSuffixText = null;
            txtEmailEditorial.ReadOnly = false;
            txtEmailEditorial.RightToLeft = RightToLeft.No;
            txtEmailEditorial.SelectedText = "";
            txtEmailEditorial.SelectionLength = 0;
            txtEmailEditorial.SelectionStart = 0;
            txtEmailEditorial.ShortcutsEnabled = true;
            txtEmailEditorial.Size = new Size(406, 48);
            txtEmailEditorial.TabIndex = 2;
            txtEmailEditorial.TabStop = false;
            txtEmailEditorial.TextAlign = HorizontalAlignment.Left;
            txtEmailEditorial.TrailingIcon = null;
            txtEmailEditorial.UseSystemPasswordChar = false;
            txtEmailEditorial.Click += materialTextBox21_Click;
            // 
            // txtTelefonoEditorial
            // 
            txtTelefonoEditorial.AccessibleName = "txtTelefonoEditorial";
            txtTelefonoEditorial.AnimateReadOnly = false;
            txtTelefonoEditorial.BackgroundImageLayout = ImageLayout.None;
            txtTelefonoEditorial.CharacterCasing = CharacterCasing.Normal;
            txtTelefonoEditorial.Depth = 0;
            txtTelefonoEditorial.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefonoEditorial.HideSelection = true;
            txtTelefonoEditorial.Hint = "Teléfono";
            txtTelefonoEditorial.LeadingIcon = null;
            txtTelefonoEditorial.Location = new Point(24, 213);
            txtTelefonoEditorial.MaxLength = 32767;
            txtTelefonoEditorial.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefonoEditorial.Name = "txtTelefonoEditorial";
            txtTelefonoEditorial.PasswordChar = '\0';
            txtTelefonoEditorial.PrefixSuffixText = null;
            txtTelefonoEditorial.ReadOnly = false;
            txtTelefonoEditorial.RightToLeft = RightToLeft.No;
            txtTelefonoEditorial.SelectedText = "";
            txtTelefonoEditorial.SelectionLength = 0;
            txtTelefonoEditorial.SelectionStart = 0;
            txtTelefonoEditorial.ShortcutsEnabled = true;
            txtTelefonoEditorial.Size = new Size(190, 48);
            txtTelefonoEditorial.TabIndex = 3;
            txtTelefonoEditorial.TabStop = false;
            txtTelefonoEditorial.TextAlign = HorizontalAlignment.Left;
            txtTelefonoEditorial.TrailingIcon = null;
            txtTelefonoEditorial.UseSystemPasswordChar = false;
            // 
            // txtCiudadEditorial
            // 
            txtCiudadEditorial.AnimateReadOnly = false;
            txtCiudadEditorial.BackgroundImageLayout = ImageLayout.None;
            txtCiudadEditorial.CharacterCasing = CharacterCasing.Normal;
            txtCiudadEditorial.Depth = 0;
            txtCiudadEditorial.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCiudadEditorial.HideSelection = true;
            txtCiudadEditorial.Hint = "Ciudad";
            txtCiudadEditorial.LeadingIcon = null;
            txtCiudadEditorial.Location = new Point(220, 213);
            txtCiudadEditorial.MaxLength = 32767;
            txtCiudadEditorial.MouseState = MaterialSkin.MouseState.OUT;
            txtCiudadEditorial.Name = "txtCiudadEditorial";
            txtCiudadEditorial.PasswordChar = '\0';
            txtCiudadEditorial.PrefixSuffixText = null;
            txtCiudadEditorial.ReadOnly = false;
            txtCiudadEditorial.RightToLeft = RightToLeft.No;
            txtCiudadEditorial.SelectedText = "";
            txtCiudadEditorial.SelectionLength = 0;
            txtCiudadEditorial.SelectionStart = 0;
            txtCiudadEditorial.ShortcutsEnabled = true;
            txtCiudadEditorial.Size = new Size(210, 48);
            txtCiudadEditorial.TabIndex = 4;
            txtCiudadEditorial.TabStop = false;
            txtCiudadEditorial.TextAlign = HorizontalAlignment.Left;
            txtCiudadEditorial.TrailingIcon = null;
            txtCiudadEditorial.UseSystemPasswordChar = false;
            // 
            // dtpRegistroEditorial
            // 
            dtpRegistroEditorial.AccessibleName = "dtpRegistroEditorial";
            dtpRegistroEditorial.Location = new Point(24, 289);
            dtpRegistroEditorial.Name = "dtpRegistroEditorial";
            dtpRegistroEditorial.Size = new Size(406, 23);
            dtpRegistroEditorial.TabIndex = 5;
            // 
            // btnGuardarEditorial
            // 
            btnGuardarEditorial.AccessibleName = "btnGuardarEditorial";
            btnGuardarEditorial.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardarEditorial.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardarEditorial.Depth = 0;
            btnGuardarEditorial.HighEmphasis = true;
            btnGuardarEditorial.Icon = null;
            btnGuardarEditorial.Location = new Point(272, 368);
            btnGuardarEditorial.Margin = new Padding(4, 6, 4, 6);
            btnGuardarEditorial.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardarEditorial.Name = "btnGuardarEditorial";
            btnGuardarEditorial.NoAccentTextColor = Color.Empty;
            btnGuardarEditorial.Size = new Size(158, 36);
            btnGuardarEditorial.TabIndex = 6;
            btnGuardarEditorial.Text = "Guardar";
            btnGuardarEditorial.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardarEditorial.UseAccentColor = false;
            btnGuardarEditorial.UseVisualStyleBackColor = true;
            // 
            // NuevaEditorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 522);
            Controls.Add(pnlNuevaEditorial);
            Name = "NuevaEditorial";
            Text = "NuevaEditorial";
            Load += NuevaEditorial_Load;
            pnlNuevaEditorial.ResumeLayout(false);
            pnlNuevaEditorial.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNuevaEditorial;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreEditorial;
        private MaterialSkin.Controls.MaterialTextBox2 txtDireccionEditorial;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmailEditorial;
        private MaterialSkin.Controls.MaterialTextBox2 txtCiudadEditorial;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefonoEditorial;
        private DateTimePicker dtpRegistroEditorial;
        private MaterialSkin.Controls.MaterialButton btnGuardarEditorial;
    }
}