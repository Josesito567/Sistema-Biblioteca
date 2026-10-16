using System.Windows.Forms;

namespace Sistema_Biblioteca.Vistas;

internal static class ResponsiveLayout
{
    public static void Apply(Control root)
    {
        foreach (Control control in root.Controls)
        {
            if (control is DataGridView grid)
            {
                grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                grid.ScrollBars = ScrollBars.Both;
                grid.AllowUserToResizeColumns = true;
                grid.AllowUserToResizeRows = true;
            }

            Apply(control);
        }
    }
}
