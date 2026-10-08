namespace Sistema_Biblioteca.Vistas.Autenticacion.Contacto;

partial class FrmContacto
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
        this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
        
        this.materialCard1.SuspendLayout();
        this.SuspendLayout();
        // 1. Configuramos el texto (Label)
        this.materialLabel1.Location = new System.Drawing.Point(17, 8); // Posición DENTRO de la tarjeta
        this.materialLabel1.Name = "materialLabel1";
        this.materialLabel1.TabIndex = 0;
        this.materialLabel1.AccessibleName = "info_desarrollador";
        this.materialLabel1.Text = "Nombre: Enoc Ezequiel Zamora Aguilar\n\nTelefono: +505 8281-3202\n\nCorreo Electronico: zamoraenoc60@gmail.com\n\nCarrera: Tecnico Especialista en Programación\n\nSEGUNDO DESARROLADOR\n\nNombre: Jose Francisco Rostran Pravia\n\nTelefono: +505 8548-2952\n\nCorreo Electronico: joses01@gmail.com\n\nCarrera: Tecnico Especialista en Programación";
        this.materialLabel1.Size = new System.Drawing.Size(368, 412);

        // 2. Configuramos la tarjeta (Card)
        this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.materialCard1.Depth = 0;
        this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.materialCard1.Location = new System.Drawing.Point(17, 78);
        this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
        this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialCard1.Name = "materialCard1";
        this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
        this.materialCard1.Size = new System.Drawing.Size(427, 153);
        this.materialCard1.TabIndex = 1;
        this.materialCard1.AccessibleName = "card_desarrollador";
        this.materialCard1.AutoScroll = true;
        this.materialCard1.Controls.Add(this.materialLabel1);
        // 3. FrmContacto (Ventana principal)
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(461, 240);
        
        // Solo agregamos la tarjeta a la ventana (el label ya va adentro de ella)
        this.Controls.Add(this.materialCard1);

        this.Name = "FrmContacto";
        this.Text = "Contacto del Desarrollador";
        this.materialCard1.ResumeLayout(false);
        this.materialCard1.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion
    private MaterialSkin.Controls.MaterialCard materialCard1;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
}