namespace Sistema_Biblioteca.Estilos;

using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MaterialSkin.Controls;
using System.Windows.Forms;

public static class ControlesTablaEstilo
{
    public static void Aplicar(MaterialTextBox2 campoBusqueda, MaterialButton botonBuscar, MaterialButton botonRefrescar)
    {
        campoBusqueda.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
        campoBusqueda.AccessibleName = "Buscar registros";
        campoBusqueda.Hint = "Buscar...";
        campoBusqueda.Size = new Size(280, 48);

        ConfigurarBoton(botonBuscar, "Buscar");
        ConfigurarBoton(botonRefrescar, "Refrescar");
        botonBuscar.AccessibleName = "Buscar registros";
        botonRefrescar.AccessibleName = "Refrescar registros";
        botonRefrescar.Type = MaterialButton.MaterialButtonType.Outlined;
    }

    public static List<T> Buscar<T>(IEnumerable<T> registros, string texto, params Func<T, string?>[] campos)
    {
        if (string.IsNullOrWhiteSpace(texto))
        {
            return registros.ToList();
        }

        texto = texto.Trim();

        return registros
            .Where(registro => campos.Any(campo =>
                (campo(registro) ?? string.Empty).Contains(texto, StringComparison.OrdinalIgnoreCase)))
            .ToList();
    }

    private static void ConfigurarBoton(MaterialButton boton, string texto)
    {
        boton.AutoSize = false;
        boton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        boton.Density = MaterialButton.MaterialButtonDensity.Default;
        boton.HighEmphasis = true;
        boton.Size = new Size(105, 36);
        boton.Text = texto;
        boton.UseAccentColor = false;
        boton.UseVisualStyleBackColor = true;
    }
}
