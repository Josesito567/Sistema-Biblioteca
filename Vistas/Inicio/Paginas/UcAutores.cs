namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using System.Windows.Forms;
using Sistema_Biblioteca.Estilos;

public partial class UcAutores : UserControl
{
    public UcAutores()
    {
        InitializeComponent();
        CargarAutoresEnLaTabla();
    }

    private void CargarAutoresEnLaTabla()
    {
        dgvAutores.DataSource = Sistema_Biblioteca.Controladores.AutoresControlador.GetAll();
        DataGridViewEstilo.Aplicar(dgvAutores, "id_autores");
    }

    private void btnAuCrear_Click(object sender, EventArgs e)
    {
        using (var modal = new Modales.NuevoAutor())
        {
            modal.ShowDialog(this);
        }
    }
}
