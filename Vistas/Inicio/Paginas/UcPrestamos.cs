namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using System.Windows.Forms;
using Sistema_Biblioteca.Estilos;

public partial class UcPrestamos : UserControl
{
    public UcPrestamos()
    {
        InitializeComponent();
        CargarPrestamosEnLaTabla();
    }

    private void CargarPrestamosEnLaTabla()
    {
        dgvPrestamos.DataSource = Sistema_Biblioteca.Controladores.PrestamosControlador.GetAll();
        DataGridViewEstilo.Aplicar(dgvPrestamos, "id_prestamos");
    }
}