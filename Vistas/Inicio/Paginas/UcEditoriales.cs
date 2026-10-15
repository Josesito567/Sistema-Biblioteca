namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using Sistema_Biblioteca.Estilos;
using Sistema_Biblioteca.Vistas.Autenticacion.Contacto;
using Sistema_Biblioteca.Vistas.Modales;
using System.Windows.Forms;

public partial class UcEditoriales : UserControl
{
    public UcEditoriales()
    {
        InitializeComponent();

        CargarEditorialesEnLaTabla();
    }
    private void CargarEditorialesEnLaTabla()
    {
        // 1. Llamamos a tu controlador directamente porque es 'static'
        var listaDeEditoriales = Sistema_Biblioteca.Controladores.EditorialesControlador.GetAll();

        // 2. Le decimos al DataGridView que su fuente de datos (DataSource) sea esa lista
        dgvEditoriales.DataSource = listaDeEditoriales;
        DataGridViewEstilo.Aplicar(dgvEditoriales, "id_editoriales");
    }

    private void btnEdCrear_Click(object sender, EventArgs e)
    {
        using (var modal = new NuevaEditorial())
        {
            modal.ShowDialog(this);
        }
    }
}