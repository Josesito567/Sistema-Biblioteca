namespace Sistema_Biblioteca.Estilos;

using System.Drawing;
using System.Windows.Forms;

public static class DataGridViewEstilo
{
    public static void Aplicar(DataGridView tabla, params string[] clavesPrimarias)
    {
        var fuenteTabla = new Font("Roboto", 10F, FontStyle.Regular);

        tabla.AllowUserToAddRows = false;
        tabla.AllowUserToDeleteRows = false;
        tabla.AllowUserToResizeRows = false;
        tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        tabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        tabla.BackgroundColor = Color.White;
        tabla.BorderStyle = BorderStyle.None;
        tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        tabla.Font = fuenteTabla;
        tabla.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.FromArgb(48, 63, 159),
            ForeColor = Color.White,
            Font = new Font("Roboto", 10F, FontStyle.Bold),
            Alignment = DataGridViewContentAlignment.MiddleLeft,
            Padding = new Padding(8, 0, 8, 0)
        };
        tabla.ColumnHeadersHeight = 42;
        tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        tabla.DefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            ForeColor = Color.FromArgb(45, 45, 45),
            Font = fuenteTabla,
            SelectionBackColor = Color.FromArgb(197, 202, 233),
            SelectionForeColor = Color.FromArgb(30, 30, 30),
            Alignment = DataGridViewContentAlignment.MiddleLeft,
            Padding = new Padding(8, 0, 8, 0)
        };
        tabla.EnableHeadersVisualStyles = false;
        tabla.GridColor = Color.FromArgb(224, 224, 224);
        tabla.MultiSelect = false;
        tabla.ReadOnly = true;
        tabla.RowHeadersVisible = false;
        tabla.RowTemplate.Height = 38;
        tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        tabla.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.FromArgb(247, 248, 252),
            ForeColor = Color.FromArgb(45, 45, 45),
            SelectionBackColor = Color.FromArgb(197, 202, 233),
            SelectionForeColor = Color.FromArgb(30, 30, 30),
            Padding = new Padding(8, 0, 8, 0)
        };

        foreach (var clavePrimaria in clavesPrimarias)
        {
            if (tabla.Columns.Contains(clavePrimaria))
            {
                tabla.Columns[clavePrimaria].Visible = false;
            }
        }

        foreach (DataGridViewColumn columna in tabla.Columns)
        {
            columna.SortMode = DataGridViewColumnSortMode.Automatic;
        }

        tabla.CellFormatting += Tabla_CellFormatting;
    }

    private static void Tabla_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (sender is not DataGridView tabla || e.RowIndex < 0 || e.ColumnIndex < 0)
        {
            return;
        }

        var nombreColumna = tabla.Columns[e.ColumnIndex].Name;

        if (nombreColumna.Equals("estado", StringComparison.OrdinalIgnoreCase))
        {
            e.Value = Convert.ToByte(e.Value ?? 0) == 1 ? "Activo" : "Inactivo";
            e.FormattingApplied = true;
        }
        else if (nombreColumna.Equals("disponible", StringComparison.OrdinalIgnoreCase))
        {
            e.Value = Convert.ToByte(e.Value ?? 0) == 1 ? "Disponible" : "No disponible";
            e.FormattingApplied = true;
        }
    }
}
