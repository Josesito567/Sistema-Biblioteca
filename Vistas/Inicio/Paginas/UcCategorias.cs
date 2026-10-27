namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

using Sistema_Biblioteca.Controladores;
using Sistema_Biblioteca.Estilos;
using Sistema_Biblioteca.Modelos;
using Sistema_Biblioteca.Vistas.Modales;
using System.Windows.Forms;

public partial class UcCategorias : UserControl
{
    private List<CategoriasModelo> categorias = new();

    public UcCategorias()
    {
        InitializeComponent();
        ControlesTablaEstilo.Aplicar(txtBuscar, btnBuscar, btnRefrescar);
        CargarCategoriasEnLaTabla();
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
    }

    private void CargarCategoriasEnLaTabla()
    {
        categorias = Sistema_Biblioteca.Controladores.CategoriasControlador.GetAll();
        AplicarFiltro();
        DataGridViewEstilo.Aplicar(dataGridView1, "id_categorias"); 
        if (!dataGridView1.Columns.Contains("btnDelete"))
        {
            dataGridView1.Columns.Add(new DataGridViewButtonColumn
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
        dataGridView1.DataSource = ControlesTablaEstilo.Buscar(
            categorias,
            txtBuscar.Text,
            categoria => categoria.nombre,
            categoria => categoria.descripcion);
    }

    private void btnBuscar_Click(object sender, EventArgs e) => AplicarFiltro();

    private void btnRefrescar_Click(object sender, EventArgs e)
    {
        txtBuscar.Clear();
        CargarCategoriasEnLaTabla();
    }

       

    private void btnNuevaCategoria_Click(object sender, EventArgs e)
    {
        using (var modal = new NuevaCategoria())
        {
            modal.ShowDialog(this);
        }
    }

    private void btnCaCrear_Click(object sender, EventArgs e)
    {
        using (var modal = new NuevaCategoria())
        {
            if (modal.ShowDialog(this) == DialogResult.OK)
            {
                CargarCategoriasEnLaTabla();
            }
        }
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex].Name != "btnDelete") return;

        int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_categorias"].Value);
        string name = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value?.ToString() ?? "";

        DialogResult result = MessageBox.Show($"¿Está seguro de eliminar la categoría '{name}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result != DialogResult.Yes) return;

        if (CategoriasControlador.Delete(id, out string mensajeError))
        {
            MessageBox.Show($"Categoría '{name}' eliminada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // CargarCategoriasEnLaTabla(); // Llama a tu método para recargar
        }
        else
        {
            MessageBox.Show(mensajeError, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
