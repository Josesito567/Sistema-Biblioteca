namespace Sistema_Biblioteca.Vistas.Modales
{
    partial class NuevoLibro
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
            btnGuardarLibro = new MaterialSkin.Controls.MaterialButton();
            dtpRegistroAutor = new DateTimePicker();
            txtDescripcionLibro = new MaterialSkin.Controls.MaterialTextBox2();
            txtTituloLibro = new MaterialSkin.Controls.MaterialTextBox2();
            dtpAnioPublicacion = new DateTimePicker();
            txtAnioPublicacionLibro = new MaterialSkin.Controls.MaterialTextBox();
            txtFechaRegistroLibro = new MaterialSkin.Controls.MaterialTextBox();
            pnlNuevaEditorial.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNuevaEditorial
            // 
            pnlNuevaEditorial.AccessibleName = "pnlNuevaEditorial";
            pnlNuevaEditorial.Controls.Add(txtFechaRegistroLibro);
            pnlNuevaEditorial.Controls.Add(txtAnioPublicacionLibro);
            pnlNuevaEditorial.Controls.Add(dtpAnioPublicacion);
            pnlNuevaEditorial.Controls.Add(btnGuardarLibro);
            pnlNuevaEditorial.Controls.Add(dtpRegistroAutor);
            pnlNuevaEditorial.Controls.Add(txtDescripcionLibro);
            pnlNuevaEditorial.Controls.Add(txtTituloLibro);
            pnlNuevaEditorial.Location = new Point(6, 67);
            pnlNuevaEditorial.Name = "pnlNuevaEditorial";
            pnlNuevaEditorial.Size = new Size(456, 449);
            pnlNuevaEditorial.TabIndex = 2;
            // 
            // btnGuardarLibro
            // 
            btnGuardarLibro.AccessibleName = "btnGuardarLibro";
            btnGuardarLibro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardarLibro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardarLibro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardarLibro.Depth = 0;
            btnGuardarLibro.HighEmphasis = true;
            btnGuardarLibro.Icon = null;
            btnGuardarLibro.Location = new Point(342, 398);
            btnGuardarLibro.Margin = new Padding(4, 6, 4, 6);
            btnGuardarLibro.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardarLibro.Name = "btnGuardarLibro";
            btnGuardarLibro.NoAccentTextColor = Color.Empty;
            btnGuardarLibro.Size = new Size(88, 36);
            btnGuardarLibro.TabIndex = 6;
            btnGuardarLibro.Text = "Guardar";
            btnGuardarLibro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardarLibro.UseAccentColor = false;
            btnGuardarLibro.UseVisualStyleBackColor = true;
            // 
            // dtpRegistroAutor
            // 
            dtpRegistroAutor.AccessibleName = "dtpRegistroAutor";
            dtpRegistroAutor.Location = new Point(24, 330);
            dtpRegistroAutor.Name = "dtpRegistroAutor";
            dtpRegistroAutor.Size = new Size(406, 23);
            dtpRegistroAutor.TabIndex = 5;
            // 
            // txtDescripcionLibro
            // 
            txtDescripcionLibro.AccessibleName = "txtDescripcionLibro";
            txtDescripcionLibro.AnimateReadOnly = false;
            txtDescripcionLibro.BackgroundImageLayout = ImageLayout.None;
            txtDescripcionLibro.CharacterCasing = CharacterCasing.Normal;
            txtDescripcionLibro.Depth = 0;
            txtDescripcionLibro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescripcionLibro.HideSelection = true;
            txtDescripcionLibro.Hint = "Descripción";
            txtDescripcionLibro.LeadingIcon = null;
            txtDescripcionLibro.Location = new Point(24, 106);
            txtDescripcionLibro.MaxLength = 32767;
            txtDescripcionLibro.MouseState = MaterialSkin.MouseState.OUT;
            txtDescripcionLibro.Name = "txtDescripcionLibro";
            txtDescripcionLibro.PasswordChar = '\0';
            txtDescripcionLibro.PrefixSuffixText = null;
            txtDescripcionLibro.ReadOnly = false;
            txtDescripcionLibro.RightToLeft = RightToLeft.No;
            txtDescripcionLibro.SelectedText = "";
            txtDescripcionLibro.SelectionLength = 0;
            txtDescripcionLibro.SelectionStart = 0;
            txtDescripcionLibro.ShortcutsEnabled = true;
            txtDescripcionLibro.Size = new Size(406, 48);
            txtDescripcionLibro.TabIndex = 2;
            txtDescripcionLibro.TabStop = false;
            txtDescripcionLibro.TextAlign = HorizontalAlignment.Left;
            txtDescripcionLibro.TrailingIcon = null;
            txtDescripcionLibro.UseSystemPasswordChar = false;
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.AccessibleName = "txtTituloLibro";
            txtTituloLibro.AnimateReadOnly = false;
            txtTituloLibro.BackgroundImageLayout = ImageLayout.None;
            txtTituloLibro.CharacterCasing = CharacterCasing.Normal;
            txtTituloLibro.Depth = 0;
            txtTituloLibro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTituloLibro.HideSelection = true;
            txtTituloLibro.Hint = "Titulo";
            txtTituloLibro.LeadingIcon = null;
            txtTituloLibro.Location = new Point(24, 39);
            txtTituloLibro.MaxLength = 32767;
            txtTituloLibro.MouseState = MaterialSkin.MouseState.OUT;
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.PasswordChar = '\0';
            txtTituloLibro.PrefixSuffixText = null;
            txtTituloLibro.ReadOnly = false;
            txtTituloLibro.RightToLeft = RightToLeft.No;
            txtTituloLibro.SelectedText = "";
            txtTituloLibro.SelectionLength = 0;
            txtTituloLibro.SelectionStart = 0;
            txtTituloLibro.ShortcutsEnabled = true;
            txtTituloLibro.Size = new Size(406, 48);
            txtTituloLibro.TabIndex = 1;
            txtTituloLibro.TabStop = false;
            txtTituloLibro.TextAlign = HorizontalAlignment.Left;
            txtTituloLibro.TrailingIcon = null;
            txtTituloLibro.UseSystemPasswordChar = false;
            // 
            // dtpAnioPublicacion
            // 
            dtpAnioPublicacion.AccessibleName = "dtpAnioPublicacion";
            dtpAnioPublicacion.Location = new Point(24, 231);
            dtpAnioPublicacion.Name = "dtpAnioPublicacion";
            dtpAnioPublicacion.Size = new Size(406, 23);
            dtpAnioPublicacion.TabIndex = 7;
            // 
            // txtAnioPublicacionLibro
            // 
            txtAnioPublicacionLibro.AccessibleDescription = "txtAnioPublicacionLibro";
            txtAnioPublicacionLibro.AnimateReadOnly = false;
            txtAnioPublicacionLibro.BorderStyle = BorderStyle.None;
            txtAnioPublicacionLibro.Depth = 0;
            txtAnioPublicacionLibro.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAnioPublicacionLibro.LeadingIcon = null;
            txtAnioPublicacionLibro.Location = new Point(24, 175);
            txtAnioPublicacionLibro.MaxLength = 50;
            txtAnioPublicacionLibro.MouseState = MaterialSkin.MouseState.OUT;
            txtAnioPublicacionLibro.Multiline = false;
            txtAnioPublicacionLibro.Name = "txtAnioPublicacionLibro";
            txtAnioPublicacionLibro.Size = new Size(166, 50);
            txtAnioPublicacionLibro.TabIndex = 8;
            txtAnioPublicacionLibro.Text = "Año de Publicación";
            txtAnioPublicacionLibro.TrailingIcon = null;
            // 
            // txtFechaRegistroLibro
            // 
            txtFechaRegistroLibro.AccessibleDescription = "txtFechaRegistroLibro";
            txtFechaRegistroLibro.AnimateReadOnly = false;
            txtFechaRegistroLibro.BorderStyle = BorderStyle.None;
            txtFechaRegistroLibro.Depth = 0;
            txtFechaRegistroLibro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFechaRegistroLibro.LeadingIcon = null;
            txtFechaRegistroLibro.Location = new Point(24, 274);
            txtFechaRegistroLibro.MaxLength = 50;
            txtFechaRegistroLibro.MouseState = MaterialSkin.MouseState.OUT;
            txtFechaRegistroLibro.Multiline = false;
            txtFechaRegistroLibro.Name = "txtFechaRegistroLibro";
            txtFechaRegistroLibro.Size = new Size(166, 50);
            txtFechaRegistroLibro.TabIndex = 9;
            txtFechaRegistroLibro.Text = "Fecha de Registro";
            txtFechaRegistroLibro.TrailingIcon = null;
            txtFechaRegistroLibro.TextChanged += materialTextBox1_TextChanged;
            // 
            // NuevoLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 522);
            Controls.Add(pnlNuevaEditorial);
            Name = "NuevoLibro";
            Text = "NuevoLibro";
            pnlNuevaEditorial.ResumeLayout(false);
            pnlNuevaEditorial.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNuevaEditorial;
        private MaterialSkin.Controls.MaterialButton btnGuardarLibro;
        private DateTimePicker dtpRegistroEditorial;
        private MaterialSkin.Controls.MaterialTextBox2 txtDescripcionLibro;
        private MaterialSkin.Controls.MaterialTextBox2 txtTituloLibro;
        private DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialTextBox txtAnioPublicacionLibro;
        private MaterialSkin.Controls.MaterialTextBox txtFechaRegistroLibro;
        private DateTimePicker dtpRegistroAutor;
        private DateTimePicker dtpAnioPublicacion;
    }
}