namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using Sistema_Biblioteca.Estilos;
using Sistema_Biblioteca.Vistas.Modales;
using System.Windows.Forms;

public partial class UcCategorias : UserControl
{
    public UcCategorias()
    {
        InitializeComponent();
        CargarCategoriasEnLaTabla();
    }

    private void CargarCategoriasEnLaTabla()
    {
        dataGridView1.DataSource = Sistema_Biblioteca.Controladores.CategoriasControlador.GetAll();
        DataGridViewEstilo.Aplicar(dataGridView1, "id_categorias");
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
            modal.ShowDialog(this);
        }
    }
}
