namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using System.Windows.Forms;

public partial class UcCatalogoLibros : UserControl
{
    public UcCatalogoLibros()
    {
        InitializeComponent();
        CargarCatalogoEnLaTabla();
    }

    private void CargarCatalogoEnLaTabla()
    {
        dgvCatalogoLibros.DataSource = Sistema_Biblioteca.Controladores.CatalogoLibrosControlador.GetAll();
    }
}
