namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using Sistema_Biblioteca.Controladores;
using Sistema_Biblioteca.Estilos;
using Sistema_Biblioteca.Modelos;
using Sistema_Biblioteca.Vistas.Autenticacion.Contacto;
using Sistema_Biblioteca.Vistas.Modales;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        if (!dgvEditoriales.Columns.Contains("btnDelete"))
        {
            dgvEditoriales.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnDelete",
                HeaderText = "",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            });
        }

        //Incluir una columna adicional para mostrar el número de libros asociados a cada editorial
        if (!dgvEditoriales.Columns.Contains("countbookbypublisher"))
        {
            dgvEditoriales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "countbookbypublisher",
                HeaderText = "Libros Asociados",
                ReadOnly = true
            });
        }

        // Actualizar el valor de la columna "countbookbypublisher" para cada fila
        foreach (DataGridViewRow row in dgvEditoriales.Rows)
        {
            if (row.DataBoundItem is EditorialesModelo editorial)
            {
                int count = EditorialesControlador.CountBookByPublisher(editorial.id_editoriales);
                    row.Cells["countbookbypublisher"].Value = count;
            }
        }

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

    private void dgvEditoriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // Asegurar que el clic fue en una fila válida y en la columna "btnDelete"
        if (e.RowIndex < 0 || dgvEditoriales.Columns[e.ColumnIndex].Name != "btnDelete")
            return;

        // Obtener el ID y Nombre
        int id = Convert.ToInt32(dgvEditoriales.Rows[e.RowIndex].Cells["id_editoriales"].Value);
        string name = dgvEditoriales.Rows[e.RowIndex].Cells["nombre"].Value?.ToString() ?? "";

        // Mensaje de confirmación
        DialogResult result = MessageBox.Show(
            $"¿Está seguro de eliminar la editorial '{name}'?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (result != DialogResult.Yes) return;

        // Ejecutar eliminación pasando 'out string mensajeError'
        if (EditorialesControlador.Delete(id, out string mensajeError))
        {
            MessageBox.Show(
                $"Editorial '{name}' eliminada correctamente.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            CargarEditorialesEnLaTabla();
        }
        else
        {
            // Muestra el motivo exacto devuelto por el controlador (ej. si tiene libros vinculados)
            MessageBox.Show(
                mensajeError,
                "Error al eliminar. Esta editorial tiene libros asociados.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
          
}