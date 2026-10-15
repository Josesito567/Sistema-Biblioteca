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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContacto));
        materialCard1 = new MaterialSkin.Controls.MaterialCard();
        materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
        materialCard1.SuspendLayout();
        SuspendLayout();
        // 
        // materialCard1
        // 
        materialCard1.AccessibleName = "card_desarrollador";
        materialCard1.AutoScroll = true;
        materialCard1.BackColor = Color.FromArgb(255, 255, 255);
        materialCard1.Controls.Add(materialLabel1);
        materialCard1.Depth = 0;
        materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
        materialCard1.Location = new Point(17, 78);
        materialCard1.Margin = new Padding(14);
        materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
        materialCard1.Name = "materialCard1";
        materialCard1.Padding = new Padding(14);
        materialCard1.Size = new Size(427, 153);
        materialCard1.TabIndex = 1;
        // 
        // materialLabel1
        // 
        materialLabel1.AccessibleName = "info_desarrollador";
        materialLabel1.Depth = 0;
        materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        materialLabel1.Location = new Point(17, 8);
        materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
        materialLabel1.Name = "materialLabel1";
        materialLabel1.Size = new Size(368, 412);
        materialLabel1.TabIndex = 0;
        materialLabel1.Text = resources.GetString("materialLabel1.Text");
        // 
        // FrmContacto
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(461, 240);
        Controls.Add(materialCard1);
        Name = "FrmContacto";
        Text = "Contacto del Desarrollador";
        materialCard1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private MaterialSkin.Controls.MaterialCard materialCard1;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
}