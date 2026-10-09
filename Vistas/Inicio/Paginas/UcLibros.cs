namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using System.Windows.Forms;

public partial class UcLibros : UserControl
{
    public UcLibros()
    {
        InitializeComponent();

        btnEditoriales.Click += (s, e) => CambiarVista(new UcEditoriales());
        btnCategorias.Click += (s, e) => CambiarVista(new UcCategorias());
        btnLibros.Click += (s, e) => CambiarVista(new UcCatalogoLibros());
        btnAutores.Click += (s, e) => CambiarVista(new UcAutores());

        CambiarVista(new UcCatalogoLibros());
    }

    private void CambiarVista(UserControl vista)
    {
        pnlContenidoLibros.Controls.Clear();
        vista.Dock = DockStyle.Fill;
        pnlContenidoLibros.Controls.Add(vista);
        vista.BringToFront();
    }
}