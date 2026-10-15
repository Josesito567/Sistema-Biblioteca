namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using System.Windows.Forms;
using Sistema_Biblioteca.Estilos;

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
}
