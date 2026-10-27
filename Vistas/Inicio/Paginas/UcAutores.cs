namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using Sistema_Biblioteca.Controladores;
using Sistema_Biblioteca.Estilos;
using Sistema_Biblioteca.Modelos;
using System.Drawing.Text;
using System.Windows.Forms;

public partial class UcAutores : UserControl
{
    private List<AutoresModelo> autores = new();

    public UcAutores()
    {
        InitializeComponent();
        ControlesTablaEstilo.Aplicar(txtBuscar, btnBuscar, btnRefrescar);
        dgvAutores.CellDoubleClick += dgvAutores_CellDoubleClick;
        CargarAutoresEnLaTabla();
    }

    private void CargarAutoresEnLaTabla()
    {
        autores = Sistema_Biblioteca.Controladores.AutoresControlador.GetAll();
        AplicarFiltro();
        DataGridViewEstilo.Aplicar(dgvAutores, "id_autores");

        // Agregar columna de eliminar si no existe
        if (!dgvAutores.Columns.Contains("btnDelete"))
        {
            dgvAutores.Columns.Add(new DataGridViewButtonColumn
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

                // refresh the DataGridView to show the newly added author
            }
        }
    }

   

    private void dgvAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvAutores.Columns[e.ColumnIndex].Name != "btnDelete") return;

        int id = Convert.ToInt32(dgvAutores.Rows[e.RowIndex].Cells["id_autores"].Value);
        string name = dgvAutores.Rows[e.RowIndex].Cells["nombre"].Value?.ToString() ?? "";

        DialogResult result = MessageBox.Show($"¿Está seguro de eliminar el autor '{name}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result != DialogResult.Yes) return;

        if (AutoresControlador.Delete(id, out string mensajeError))
        {
            MessageBox.Show($"Autor '{name}' eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarAutoresEnLaTabla();
        }
        else
        {
            MessageBox.Show(mensajeError, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
