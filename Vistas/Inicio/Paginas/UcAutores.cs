namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using Sistema_Biblioteca.Modelos;
using System.Windows.Forms;
using Sistema_Biblioteca.Estilos;

public partial class UcAutores : UserControl
{
    private List<AutoresModelo> autores = new();

    public UcAutores()
    {
        InitializeComponent();
        ControlesTablaEstilo.Aplicar(txtBuscar, btnBuscar, btnRefrescar);
        CargarAutoresEnLaTabla();
    }

    private void CargarAutoresEnLaTabla()
    {
        autores = Sistema_Biblioteca.Controladores.AutoresControlador.GetAll();
        AplicarFiltro();
        DataGridViewEstilo.Aplicar(dgvAutores, "id_autores");
    }

    private void AplicarFiltro()
    {
        dgvAutores.DataSource = ControlesTablaEstilo.Buscar(
            autores,
            txtBuscar.Text,
            autor => autor.nombre,
            autor => autor.nacionalidad,
            autor => autor.telefono,
            autor => autor.email);
    }

    private void btnBuscar_Click(object sender, EventArgs e) => AplicarFiltro();

    private void btnRefrescar_Click(object sender, EventArgs e)
    {
        txtBuscar.Clear();
        CargarAutoresEnLaTabla();
    }

    private void btnAuCrear_Click(object sender, EventArgs e)
    {
        using (var modal = new Modales.NuevoAutor())
        {
            if (modal.ShowDialog(this) == DialogResult.OK)
            {
                CargarAutoresEnLaTabla();
            }
        }
    }
}
