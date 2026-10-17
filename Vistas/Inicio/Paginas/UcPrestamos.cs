namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using Sistema_Biblioteca.Estilos;
using System.Windows.Forms;
using Sistema_Biblioteca.Modelos;

public partial class UcPrestamos : UserControl
{
    private List<PrestamosModelo> prestamos = new();

    public UcPrestamos()
    {
        InitializeComponent();
        ControlesTablaEstilo.Aplicar(txtBuscar, btnBuscar, btnRefrescar);
        CargarPrestamosEnLaTabla();
    }

    private void CargarPrestamosEnLaTabla()
    {
        prestamos = Sistema_Biblioteca.Controladores.PrestamosControlador.GetAll();
        AplicarFiltro();
        DataGridViewEstilo.Aplicar(dgvPrestamos, "id_prestamos");
    }

    private void AplicarFiltro()
    {
        dgvPrestamos.DataSource = ControlesTablaEstilo.Buscar(
            prestamos,
            txtBuscar.Text,
            prestamo => prestamo.nombre_solicitante,
            prestamo => prestamo.identificacion,
            prestamo => prestamo.telefono,
            prestamo => prestamo.observaciones,
            prestamo => prestamo.fecha_prestamo.ToString("dd/MM/yyyy"),
            prestamo => prestamo.fecha_devolucion_esperada.ToString("dd/MM/yyyy"));
    }

    private void btnBuscar_Click(object sender, EventArgs e) => AplicarFiltro();

    private void btnRefrescar_Click(object sender, EventArgs e)
    {
        txtBuscar.Clear();
        CargarPrestamosEnLaTabla();
    }
}