namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using MaterialSkin.Controls;
using System.Windows.Forms;

public partial class UcLibros : UserControl
{
    public UcLibros()
    {
        InitializeComponent();

        btnEditoriales.Click += (s, e) => CambiarVista(btnEditoriales, new UcEditoriales());
        btnCategorias.Click += (s, e) => CambiarVista(btnCategorias, new UcCategorias());
        btnLibros.Click += (s, e) => CambiarVista(btnLibros, new UcCatalogoLibros());
        btnAutores.Click += (s, e) => CambiarVista(btnAutores, new UcAutores());

        CambiarVista(btnLibros, new UcCatalogoLibros());
    }

    private void CambiarVista(MaterialButton botonActivo, UserControl vista)
    {
        btnEditoriales.Type = MaterialButton.MaterialButtonType.Outlined;
        btnCategorias.Type = MaterialButton.MaterialButtonType.Outlined;
        btnLibros.Type = MaterialButton.MaterialButtonType.Outlined;
        btnAutores.Type = MaterialButton.MaterialButtonType.Outlined;
        botonActivo.Type = MaterialButton.MaterialButtonType.Contained;

        pnlContenidoLibros.Controls.Clear();
        vista.Dock = DockStyle.Fill;
        pnlContenidoLibros.Controls.Add(vista);
        vista.BringToFront();
    }
}