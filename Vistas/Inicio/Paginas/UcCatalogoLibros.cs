namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using System.Windows.Forms;
using Sistema_Biblioteca.Estilos;

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
        DataGridViewEstilo.Aplicar(dgvCatalogoLibros, "id_catalogolibros", "id_libros");
    }

    private void btnLiCrear_Click(object sender, EventArgs e)
    {
        using (var modal = new Modales.NuevoLibro())
        {
            modal.ShowDialog(this);
        }
    }
}
