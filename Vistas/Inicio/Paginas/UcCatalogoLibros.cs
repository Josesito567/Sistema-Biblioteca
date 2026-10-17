namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using Sistema_Biblioteca.Modelos;
using System.Windows.Forms;
using Sistema_Biblioteca.Estilos;

public partial class UcCatalogoLibros : UserControl
{
    private List<CatalogoLibrosListadoModelo> catalogo = new();

    public UcCatalogoLibros()
    {
        InitializeComponent();
        ControlesTablaEstilo.Aplicar(txtBuscar, btnBuscar, btnRefrescar);
        CargarCatalogoEnLaTabla();
    }

    private void CargarCatalogoEnLaTabla()
    {
        catalogo = Sistema_Biblioteca.Controladores.CatalogoLibrosControlador.GetAll();
        AplicarFiltro();
        DataGridViewEstilo.Aplicar(dgvCatalogoLibros, "id_catalogolibros", "id_libros");
    }

    private void AplicarFiltro()
    {
        dgvCatalogoLibros.DataSource = ControlesTablaEstilo.Buscar(
            catalogo,
            txtBuscar.Text,
            libro => libro.titulo,
            libro => libro.codigo_ejemplar,
            libro => libro.ubicacion_estante,
            libro => libro.numero_edicion);
    }

    private void btnBuscar_Click(object sender, EventArgs e) => AplicarFiltro();

    private void btnRefrescar_Click(object sender, EventArgs e)
    {
        txtBuscar.Clear();
        CargarCatalogoEnLaTabla();
    }

    private void btnLiCrear_Click(object sender, EventArgs e)
    {
        using (var modal = new Modales.NuevoLibro())
        {
            if (modal.ShowDialog(this) == DialogResult.OK)
            {
                CargarCatalogoEnLaTabla();
            }
        }
    }
}
