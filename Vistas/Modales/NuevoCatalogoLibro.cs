using MaterialSkin;
using MaterialSkin.Controls;
using Sistema_Biblioteca.Controladores;
using Sistema_Biblioteca.Modelos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Biblioteca.Vistas.Modales;

public sealed class NuevoCatalogoLibro : MaterialForm
{
    private readonly CatalogoLibrosListadoModelo? registroEditar;
    private readonly ComboBox cmbLibro = new();
    private readonly TextBox txtCodigoEjemplar = new();
    private readonly TextBox txtUbicacionEstante = new();
    private readonly TextBox txtNumeroEdicion = new();
    private readonly CheckBox chkDisponible = new();
    private readonly CheckBox chkActivo = new();
    private readonly MaterialButton btnGuardar = new();

    public NuevoCatalogoLibro(CatalogoLibrosListadoModelo? registro = null)
    {
        registroEditar = registro;
        Text = registroEditar is null ? "Nuevo ejemplar" : "Editar ejemplar";
        StartPosition = FormStartPosition.CenterParent;
        MaximizeBox = false;
        MinimizeBox = false;
        ClientSize = new System.Drawing.Size(520, 490);

        MaterialSkinManager.Instance.AddFormToManage(this);
        ConstruirFormulario();
        CargarLibros();
    }

    private void ConstruirFormulario()
    {
        var panel = new Panel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(24),
            AutoScroll = true
        };

        var lblLibro = CrearEtiqueta("Libro", 24, 20);
        cmbLibro.Location = new System.Drawing.Point(24, 48);
        cmbLibro.Size = new System.Drawing.Size(448, 30);
        cmbLibro.DropDownStyle = ComboBoxStyle.DropDownList;

        PrepararCampo(txtCodigoEjemplar, "Código del ejemplar", 24, 98);
        PrepararCampo(txtUbicacionEstante, "Ubicación del estante", 24, 158);
        PrepararCampo(txtNumeroEdicion, "Número de edición", 24, 218);

        chkDisponible.Text = "Disponible para préstamo";
        chkDisponible.AutoSize = true;
        chkDisponible.Location = new System.Drawing.Point(24, 282);
        chkDisponible.Checked = true;

        chkActivo.Text = "Ejemplar activo";
        chkActivo.AutoSize = true;
        chkActivo.Location = new System.Drawing.Point(24, 315);
        chkActivo.Checked = true;

        btnGuardar.Text = registroEditar is null ? "Guardar ejemplar" : "Actualizar ejemplar";
        btnGuardar.Location = new System.Drawing.Point(24, 370);
        btnGuardar.Size = new System.Drawing.Size(448, 42);
        btnGuardar.Click += BtnGuardar_Click;

        panel.Controls.AddRange(new Control[]
        {
            lblLibro, cmbLibro, txtCodigoEjemplar, txtUbicacionEstante,
            txtNumeroEdicion, chkDisponible, chkActivo, btnGuardar
        });
        Controls.Add(panel);
    }

    private static Label CrearEtiqueta(string texto, int x, int y)
    {
        return new Label
        {
            Text = texto,
            AutoSize = true,
            Location = new System.Drawing.Point(x, y)
        };
    }

    private static void PrepararCampo(TextBox campo, string texto, int x, int y)
    {
        campo.PlaceholderText = texto;
        campo.Location = new System.Drawing.Point(x, y);
        campo.Size = new System.Drawing.Size(448, 30);
    }

    private void CargarLibros()
    {
        var libros = LibrosControlador.GetAll();
        cmbLibro.DataSource = libros;
        cmbLibro.DisplayMember = nameof(LibrosModelo.titulo);
        cmbLibro.ValueMember = nameof(LibrosModelo.id_libros);

        if (registroEditar is not null)
        {
            cmbLibro.SelectedValue = registroEditar.id_libros;
            txtCodigoEjemplar.Text = registroEditar.codigo_ejemplar;
            txtUbicacionEstante.Text = registroEditar.ubicacion_estante ?? "";
            txtNumeroEdicion.Text = registroEditar.numero_edicion ?? "";
            chkDisponible.Checked = registroEditar.disponible == 1;
            chkActivo.Checked = registroEditar.estado == 1;
        }
    }

    private void BtnGuardar_Click(object? sender, EventArgs e)
    {
        if (cmbLibro.SelectedValue is not int idLibro ||
            string.IsNullOrWhiteSpace(txtCodigoEjemplar.Text))
        {
            MessageBox.Show(
                "Seleccione un libro e indique el código del ejemplar.",
                "Datos incompletos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var codigo = txtCodigoEjemplar.Text.Trim();
        var existe = CatalogoLibrosControlador.ExisteCodigo(
            codigo,
            registroEditar?.id_catalogolibros ?? 0);

        if (existe)
        {
            MessageBox.Show(
                "Ya existe un ejemplar con ese código.",
                "Código duplicado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var catalogo = new CatalogoLibrosModelo
        {
            id_catalogolibros = registroEditar?.id_catalogolibros ?? 0,
            id_libros = idLibro,
            codigo_ejemplar = codigo,
            ubicacion_estante = TextoOpcional(txtUbicacionEstante.Text),
            numero_edicion = TextoOpcional(txtNumeroEdicion.Text),
            disponible = (byte)(chkDisponible.Checked ? 1 : 0),
            estado = (byte)(chkActivo.Checked ? 1 : 0),
            fecha_registro = registroEditar?.fecha_registro ?? DateTime.Now
        };

        if (registroEditar is null)
        {
            CatalogoLibrosControlador.Create(catalogo);
        }
        else
        {
            CatalogoLibrosControlador.Update(catalogo);
        }

        MessageBox.Show(
            registroEditar is null
                ? "El ejemplar se ha creado correctamente."
                : "El ejemplar se ha actualizado correctamente.",
            "Operación completada",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        DialogResult = DialogResult.OK;
        Close();
    }

    private static string? TextoOpcional(string valor)
    {
        var texto = valor.Trim();
        return texto.Length == 0 ? null : texto;
    }
}
