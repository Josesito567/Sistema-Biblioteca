namespace Sistema_Biblioteca.Vistas.Modales
{
    partial class NuevoAutor
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
            btnGuardarAutor = new MaterialSkin.Controls.MaterialButton();
            dtpRegistroEditorial = new DateTimePicker();
            txtCiudadEAutor = new MaterialSkin.Controls.MaterialTextBox2();
            txtTelefonoAutor = new MaterialSkin.Controls.MaterialTextBox2();
            txtEmailAutor = new MaterialSkin.Controls.MaterialTextBox2();
            txtNombreAutor = new MaterialSkin.Controls.MaterialTextBox2();
            pnlNuevaEditorial.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNuevaEditorial
            // 
            pnlNuevaEditorial.AccessibleName = "pnlNuevaEditorial";
            pnlNuevaEditorial.Controls.Add(btnGuardarAutor);
            pnlNuevaEditorial.Controls.Add(dtpRegistroEditorial);
            pnlNuevaEditorial.Controls.Add(txtCiudadEAutor);
            pnlNuevaEditorial.Controls.Add(txtTelefonoAutor);
            pnlNuevaEditorial.Controls.Add(txtEmailAutor);
            pnlNuevaEditorial.Controls.Add(txtNombreAutor);
            pnlNuevaEditorial.Location = new Point(6, 67);
            pnlNuevaEditorial.Name = "pnlNuevaEditorial";
            pnlNuevaEditorial.Size = new Size(456, 449);
            pnlNuevaEditorial.TabIndex = 1;
            // 
            // btnGuardarAutor
            // 
            btnGuardarAutor.AccessibleName = "btnGuardarAutor";
            btnGuardarAutor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardarAutor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardarAutor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardarAutor.Depth = 0;
            btnGuardarAutor.HighEmphasis = true;
            btnGuardarAutor.Icon = null;
            btnGuardarAutor.Location = new Point(342, 398);
            btnGuardarAutor.Margin = new Padding(4, 6, 4, 6);
            btnGuardarAutor.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardarAutor.Name = "btnGuardarAutor";
            btnGuardarAutor.NoAccentTextColor = Color.Empty;
            btnGuardarAutor.Size = new Size(88, 36);
            btnGuardarAutor.TabIndex = 6;
            btnGuardarAutor.Text = "Guardar";
            btnGuardarAutor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardarAutor.UseAccentColor = false;
            btnGuardarAutor.UseVisualStyleBackColor = true;
            // 
            // dtpRegistroEditorial
            // 
            dtpRegistroEditorial.AccessibleName = "dtpRegistroEditorial";
            dtpRegistroEditorial.Location = new Point(24, 241);
            dtpRegistroEditorial.Name = "dtpRegistroEditorial";
            dtpRegistroEditorial.Size = new Size(406, 23);
            dtpRegistroEditorial.TabIndex = 5;
            // 
            // txtCiudadEAutor
            // 
            txtCiudadEAutor.AnimateReadOnly = false;
            txtCiudadEAutor.BackgroundImageLayout = ImageLayout.None;
            txtCiudadEAutor.CharacterCasing = CharacterCasing.Normal;
            txtCiudadEAutor.Depth = 0;
            txtCiudadEAutor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCiudadEAutor.HideSelection = true;
            txtCiudadEAutor.Hint = "Ciudad";
            txtCiudadEAutor.LeadingIcon = null;
            txtCiudadEAutor.Location = new Point(220, 173);
            txtCiudadEAutor.MaxLength = 32767;
            txtCiudadEAutor.MouseState = MaterialSkin.MouseState.OUT;
            txtCiudadEAutor.Name = "txtCiudadEAutor";
            txtCiudadEAutor.PasswordChar = '\0';
            txtCiudadEAutor.PrefixSuffixText = null;
            txtCiudadEAutor.ReadOnly = false;
            txtCiudadEAutor.RightToLeft = RightToLeft.No;
            txtCiudadEAutor.SelectedText = "";
            txtCiudadEAutor.SelectionLength = 0;
            txtCiudadEAutor.SelectionStart = 0;
            txtCiudadEAutor.ShortcutsEnabled = true;
            txtCiudadEAutor.Size = new Size(210, 48);
            txtCiudadEAutor.TabIndex = 4;
            txtCiudadEAutor.TabStop = false;
            txtCiudadEAutor.TextAlign = HorizontalAlignment.Left;
            txtCiudadEAutor.TrailingIcon = null;
            txtCiudadEAutor.UseSystemPasswordChar = false;
            // 
            // txtTelefonoAutor
            // 
            txtTelefonoAutor.AccessibleName = "txtTelefonoAutor";
            txtTelefonoAutor.AnimateReadOnly = false;
            txtTelefonoAutor.BackgroundImageLayout = ImageLayout.None;
            txtTelefonoAutor.CharacterCasing = CharacterCasing.Normal;
            txtTelefonoAutor.Depth = 0;
            txtTelefonoAutor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefonoAutor.HideSelection = true;
            txtTelefonoAutor.Hint = "Teléfono";
            txtTelefonoAutor.LeadingIcon = null;
            txtTelefonoAutor.Location = new Point(24, 173);
            txtTelefonoAutor.MaxLength = 32767;
            txtTelefonoAutor.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefonoAutor.Name = "txtTelefonoAutor";
            txtTelefonoAutor.PasswordChar = '\0';
            txtTelefonoAutor.PrefixSuffixText = null;
            txtTelefonoAutor.ReadOnly = false;
            txtTelefonoAutor.RightToLeft = RightToLeft.No;
            txtTelefonoAutor.SelectedText = "";
            txtTelefonoAutor.SelectionLength = 0;
            txtTelefonoAutor.SelectionStart = 0;
            txtTelefonoAutor.ShortcutsEnabled = true;
            txtTelefonoAutor.Size = new Size(190, 48);
            txtTelefonoAutor.TabIndex = 3;
            txtTelefonoAutor.TabStop = false;
            txtTelefonoAutor.TextAlign = HorizontalAlignment.Left;
            txtTelefonoAutor.TrailingIcon = null;
            txtTelefonoAutor.UseSystemPasswordChar = false;
            // 
            // txtEmailAutor
            // 
            txtEmailAutor.AccessibleName = "txtEmailAutor";
            txtEmailAutor.AnimateReadOnly = false;
            txtEmailAutor.BackgroundImageLayout = ImageLayout.None;
            txtEmailAutor.CharacterCasing = CharacterCasing.Normal;
            txtEmailAutor.Depth = 0;
            txtEmailAutor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmailAutor.HideSelection = true;
            txtEmailAutor.Hint = "Email";
            txtEmailAutor.LeadingIcon = null;
            txtEmailAutor.Location = new Point(24, 106);
            txtEmailAutor.MaxLength = 32767;
            txtEmailAutor.MouseState = MaterialSkin.MouseState.OUT;
            txtEmailAutor.Name = "txtEmailAutor";
            txtEmailAutor.PasswordChar = '\0';
            txtEmailAutor.PrefixSuffixText = null;
            txtEmailAutor.ReadOnly = false;
            txtEmailAutor.RightToLeft = RightToLeft.No;
            txtEmailAutor.SelectedText = "";
            txtEmailAutor.SelectionLength = 0;
            txtEmailAutor.SelectionStart = 0;
            txtEmailAutor.ShortcutsEnabled = true;
            txtEmailAutor.Size = new Size(406, 48);
            txtEmailAutor.TabIndex = 2;
            txtEmailAutor.TabStop = false;
            txtEmailAutor.TextAlign = HorizontalAlignment.Left;
            txtEmailAutor.TrailingIcon = null;
            txtEmailAutor.UseSystemPasswordChar = false;
            // 
            // txtNombreAutor
            // 
            txtNombreAutor.AccessibleName = "txtNombreAutor";
            txtNombreAutor.AnimateReadOnly = false;
            txtNombreAutor.BackgroundImageLayout = ImageLayout.None;
            txtNombreAutor.CharacterCasing = CharacterCasing.Normal;
            txtNombreAutor.Depth = 0;
            txtNombreAutor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreAutor.HideSelection = true;
            txtNombreAutor.Hint = "Nombre";
            txtNombreAutor.LeadingIcon = null;
            txtNombreAutor.Location = new Point(24, 39);
            txtNombreAutor.MaxLength = 32767;
            txtNombreAutor.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreAutor.Name = "txtNombreAutor";
            txtNombreAutor.PasswordChar = '\0';
            txtNombreAutor.PrefixSuffixText = null;
            txtNombreAutor.ReadOnly = false;
            txtNombreAutor.RightToLeft = RightToLeft.No;
            txtNombreAutor.SelectedText = "";
            txtNombreAutor.SelectionLength = 0;
            txtNombreAutor.SelectionStart = 0;
            txtNombreAutor.ShortcutsEnabled = true;
            txtNombreAutor.Size = new Size(406, 48);
            txtNombreAutor.TabIndex = 1;
            txtNombreAutor.TabStop = false;
            txtNombreAutor.TextAlign = HorizontalAlignment.Left;
            txtNombreAutor.TrailingIcon = null;
            txtNombreAutor.UseSystemPasswordChar = false;
            // 
            // NuevoAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 522);
            Controls.Add(pnlNuevaEditorial);
            Name = "NuevoAutor";
            Text = "NuevoAutor";
            pnlNuevaEditorial.ResumeLayout(false);
            pnlNuevaEditorial.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNuevaEditorial;
        private MaterialSkin.Controls.MaterialButton btnGuardarAutor;
        private DateTimePicker dtpRegistroEditorial;
        private MaterialSkin.Controls.MaterialTextBox2 txtCiudadEAutor;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefonoAutor;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmailAutor;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreAutor;
    }
}