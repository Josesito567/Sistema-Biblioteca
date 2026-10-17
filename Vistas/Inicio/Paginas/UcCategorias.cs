namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using Sistema_Biblioteca.Modelos;
using Sistema_Biblioteca.Estilos;
using Sistema_Biblioteca.Vistas.Modales;
using System.Windows.Forms;

public partial class UcCategorias : UserControl
{
    private List<CategoriasModelo> categorias = new();

    public UcCategorias()
    {
        InitializeComponent();
        ControlesTablaEstilo.Aplicar(txtBuscar, btnBuscar, btnRefrescar);
        CargarCategoriasEnLaTabla();
    }

    private void CargarCategoriasEnLaTabla()
    {
        categorias = Sistema_Biblioteca.Controladores.CategoriasControlador.GetAll();
        AplicarFiltro();
        DataGridViewEstilo.Aplicar(dataGridView1, "id_categorias");
    }

    private void AplicarFiltro()
    {
        dataGridView1.DataSource = ControlesTablaEstilo.Buscar(
            categorias,
            txtBuscar.Text,
            categoria => categoria.nombre,
            categoria => categoria.descripcion);
    }

    private void btnBuscar_Click(object sender, EventArgs e) => AplicarFiltro();

    private void btnRefrescar_Click(object sender, EventArgs e)
    {
        txtBuscar.Clear();
        CargarCategoriasEnLaTabla();
    }

    private void btnNuevaCategoria_Click(object sender, EventArgs e)
    {
        using (var modal = new NuevaCategoria())
        {
            modal.ShowDialog(this);
        }
    }

    private void btnCaCrear_Click(object sender, EventArgs e)
    {
        using (var modal = new NuevaCategoria())
        {
            if (modal.ShowDialog(this) == DialogResult.OK)
            {
                CargarCategoriasEnLaTabla();
            }
        }
    }
}
