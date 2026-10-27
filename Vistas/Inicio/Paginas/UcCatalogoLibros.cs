namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using Sistema_Biblioteca.Controladores;
using Sistema_Biblioteca.Estilos;
using Sistema_Biblioteca.Modelos;
using System.Windows.Forms;

public partial class UcCatalogoLibros : UserControl
{
    private List<CatalogoLibrosListadoModelo> catalogo = new();

    public UcCatalogoLibros()
    {
        InitializeComponent();
        ControlesTablaEstilo.Aplicar(txtBuscar, btnBuscar, btnRefrescar);
        dgvCatalogoLibros.CellDoubleClick += dgvCatalogoLibros_CellDoubleClick;
        dgvCatalogoLibros.CellContentClick += dgvCatalogoLibros_CellContentClick;
        CargarCatalogoEnLaTabla();
    }

    private void CargarCatalogoEnLaTabla()
    {
        catalogo = Sistema_Biblioteca.Controladores.CatalogoLibrosControlador.GetAll();
        AplicarFiltro();
        DataGridViewEstilo.Aplicar(dgvCatalogoLibros, "id_catalogolibros", "id_libros"); 
        if (!dgvCatalogoLibros.Columns.Contains("btnDelete"))
        {
            dgvCatalogoLibros.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnDelete",
                HeaderText = "",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            });
        }
    }

    private void AplicarFiltro()
    {
        dgvCatalogoLibros.DataSource = ControlesTablaEstilo.Buscar(
            catalogo,
            txtBuscar.Text,
            libro => libro.titulo,
            libro => libro.codigo_ejemplar,
            libro => libro.ubicacion_estante,
            libro => libro.numero_edicion);
    }

    private void btnBuscar_Click(object sender, EventArgs e) => AplicarFiltro();

    private void btnRefrescar_Click(object sender, EventArgs e)
    {
        txtBuscar.Clear();
        CargarCatalogoEnLaTabla();
    }

    private void btnLiCrear_Click(object sender, EventArgs e)
    {
        using (var modal = new Modales.NuevoCatalogoLibro())
        {
            if (modal.ShowDialog(this) == DialogResult.OK)
            {
                CargarCatalogoEnLaTabla();
            }
        }
    }

    private void dgvCatalogoLibros_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 ||
            dgvCatalogoLibros.Rows[e.RowIndex].DataBoundItem is not CatalogoLibrosListadoModelo registro)
        {
            return;
        }

        using var modal = new Modales.NuevoCatalogoLibro(registro);
        if (modal.ShowDialog(this) == DialogResult.OK)
        {
            CargarCatalogoEnLaTabla();
        }
    }

    private void dgvCatalogoLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvCatalogoLibros.Columns[e.ColumnIndex].Name != "btnDelete") return;

        int id = Convert.ToInt32(dgvCatalogoLibros.Rows[e.RowIndex].Cells["id_catalogolibros"].Value);
        string titulo = dgvCatalogoLibros.Rows[e.RowIndex].Cells["titulo"].Value?.ToString() ?? "";

        DialogResult result = MessageBox.Show($"¿Está seguro de eliminar el libro '{titulo}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result != DialogResult.Yes) return;

        if (CatalogoLibrosControlador.Delete(id, out string mensajeError))
        {
            MessageBox.Show($"Libro '{titulo}' eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarCatalogoEnLaTabla();
        }
        else
        {
            MessageBox.Show(mensajeError, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
