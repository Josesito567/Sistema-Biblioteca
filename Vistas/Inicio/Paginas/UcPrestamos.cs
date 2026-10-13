namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using System.Windows.Forms;

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
    }
}