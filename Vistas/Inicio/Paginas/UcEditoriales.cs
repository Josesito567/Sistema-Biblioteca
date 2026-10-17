namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using Sistema_Biblioteca.Estilos;
using Sistema_Biblioteca.Modelos;
using Sistema_Biblioteca.Vistas.Autenticacion.Contacto;
using Sistema_Biblioteca.Vistas.Modales;
using System.Windows.Forms;

public partial class UcEditoriales : UserControl
{
    private List<EditorialesModelo> editoriales = new();

    public UcEditoriales()
    {
        InitializeComponent();

        CargarEditorialesEnLaTabla();
    }
    private void CargarEditorialesEnLaTabla()
    {
        // 1. Llamamos a tu controlador directamente porque es 'static'
        editoriales = Sistema_Biblioteca.Controladores.EditorialesControlador.GetAll();

        AplicarFiltro();
        DataGridViewEstilo.Aplicar(dgvEditoriales, "id_editoriales");
    }

    private void AplicarFiltro()
    {
        dgvEditoriales.DataSource = ControlesTablaEstilo.Buscar(
            editoriales,
            txtBuscar.Text,
            editorial => editorial.nombre,
            editorial => editorial.direccion,
            editorial => editorial.ciudad,
            editorial => editorial.telefono,
            editorial => editorial.email);
    }

    private void btnBuscar_Click(object sender, EventArgs e) => AplicarFiltro();

    private void btnRefrescar_Click(object sender, EventArgs e)
    {
        txtBuscar.Clear();
        CargarEditorialesEnLaTabla();
    }

    private void btnEdCrear_Click(object sender, EventArgs e)
    {
        using (var modal = new NuevaEditorial())
        {
            if (modal.ShowDialog(this) == DialogResult.OK)
            {
                CargarEditorialesEnLaTabla();
            }
        }
    }
}