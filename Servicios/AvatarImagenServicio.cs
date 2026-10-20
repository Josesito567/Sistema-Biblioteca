using ImageProcessor;
using ImageProcessor.Imaging;
using ImageProcessor.Imaging.Formats;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Text;

namespace Sistema_Biblioteca.Servicios;

public static class AvatarImagenServicio
{
    public const int TamanoAvatar = 120;
    public const int CalidadJpeg = 85;

    public static byte[] CrearAvatarPredeterminado(string nombreUsuario)
    {
        var nombre = string.IsNullOrWhiteSpace(nombreUsuario) ? "Usuario" : nombreUsuario.Trim();
        var iniciales = ObtenerIniciales(nombre);
        var semilla = SHA256.HashData(Encoding.UTF8.GetBytes(nombre.ToUpperInvariant()));
        var color = Color.FromArgb(255, semilla[0], semilla[1], semilla[2]);

        using var avatar = new Bitmap(TamanoAvatar, TamanoAvatar, PixelFormat.Format32bppArgb);
        using var graphics = Graphics.FromImage(avatar);
        using var pincel = new SolidBrush(color);
        using var fuente = new Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Pixel);
        using var formato = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        graphics.Clear(Color.White);
        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
        graphics.FillRectangle(pincel, 0, 0, avatar.Width, avatar.Height);
        graphics.DrawString(iniciales, fuente, Brushes.White,
            new RectangleF(0, 0, avatar.Width, avatar.Height), formato);

        using var resultado = new MemoryStream();
        avatar.Save(resultado, ImageFormat.Png);
        return resultado.ToArray();
    }

    public static byte[] ConvertirDesdeArchivo(string rutaArchivo)
    {
        if (string.IsNullOrWhiteSpace(rutaArchivo))
        {
            throw new ArgumentException("La ruta de la imagen es obligatoria.", nameof(rutaArchivo));
        }

        if (!File.Exists(rutaArchivo))
        {
            throw new FileNotFoundException("No se encontró la imagen del perfil.", rutaArchivo);
        }

        using var imagen = new ImageFactory(preserveExifData: false);
        using var resultado = new MemoryStream();

        imagen.Load(rutaArchivo)
            .Resize(new ResizeLayer(
                new Size(TamanoAvatar, TamanoAvatar),
                ResizeMode.Crop))
            .Format(new JpegFormat { Quality = CalidadJpeg })
            .Save(resultado);

        return resultado.ToArray();
    }

    private static string ObtenerIniciales(string nombre)
    {
        var partes = nombre.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (partes.Length == 1)
        {
            return partes[0][..Math.Min(2, partes[0].Length)].ToUpperInvariant();
        }

        return $"{partes[0][0]}{partes[^1][0]}".ToUpperInvariant();
    }
}
