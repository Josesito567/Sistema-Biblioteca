using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Sistema_Biblioteca.Controles;

public class picFotoPerfilCircular : PictureBox
{
    public picFotoPerfilCircular()
    {
        SizeMode = PictureBoxSizeMode.Zoom;
        Size = new Size(120, 120);
        TabStop = false;
    }

    protected override void OnResize(EventArgs eventargs)
    {
        base.OnResize(eventargs);
        ActualizarRegionCircular();
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        pe.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        pe.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
        base.OnPaint(pe);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Region?.Dispose();
        }

        base.Dispose(disposing);
    }

    private void ActualizarRegionCircular()
    {
        if (Width <= 0 || Height <= 0)
        {
            return;
        }

        var lado = Math.Min(Width, Height);
        var x = (Width - lado) / 2;
        var y = (Height - lado) / 2;

        using var ruta = new GraphicsPath();
        ruta.AddEllipse(x, y, lado, lado);

        Region?.Dispose();
        Region = new Region(ruta);
    }
}
