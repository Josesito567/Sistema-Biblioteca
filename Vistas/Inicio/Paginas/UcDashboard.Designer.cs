namespace Sistema_Biblioteca.Vistas.Inicio.Paginas;

partial class UcDashboard
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        tablaMetricas = new TableLayoutPanel();
        cardLibrosTotales = new MaterialSkin.Controls.MaterialCard();
        lblLibrosTotalesTitulo = new MaterialSkin.Controls.MaterialLabel();
        lblLibrosTotalesValor = new MaterialSkin.Controls.MaterialLabel();
        cardPrestamosActivos = new MaterialSkin.Controls.MaterialCard();
        lblPrestamosActivosTitulo = new MaterialSkin.Controls.MaterialLabel();
        lblPrestamosActivosValor = new MaterialSkin.Controls.MaterialLabel();
        cardUsuarios = new MaterialSkin.Controls.MaterialCard();
        lblUsuariosTitulo = new MaterialSkin.Controls.MaterialLabel();
        lblUsuariosValor = new MaterialSkin.Controls.MaterialLabel();
        cardDevoluciones = new MaterialSkin.Controls.MaterialCard();
        lblDevolucionesTitulo = new MaterialSkin.Controls.MaterialLabel();
        lblDevolucionesValor = new MaterialSkin.Controls.MaterialLabel();
        cardActividadesRecientes = new MaterialSkin.Controls.MaterialCard();
        lblActividadesTitulo = new MaterialSkin.Controls.MaterialLabel();
        pnlEstadoVacio = new Panel();
        lblIconoEstado = new MaterialSkin.Controls.MaterialLabel();
        lblTituloEstado = new MaterialSkin.Controls.MaterialLabel();
        lblSubtituloEstado = new MaterialSkin.Controls.MaterialLabel();
        tablaMetricas.SuspendLayout();
        cardLibrosTotales.SuspendLayout();
        cardPrestamosActivos.SuspendLayout();
        cardUsuarios.SuspendLayout();
        cardDevoluciones.SuspendLayout();
        cardActividadesRecientes.SuspendLayout();
        pnlEstadoVacio.SuspendLayout();
        SuspendLayout();
        // 
        // tablaMetricas
        // 
        tablaMetricas.ColumnCount = 4;
        tablaMetricas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tablaMetricas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tablaMetricas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tablaMetricas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tablaMetricas.Controls.Add(cardLibrosTotales, 0, 0);
        tablaMetricas.Controls.Add(cardPrestamosActivos, 1, 0);
        tablaMetricas.Controls.Add(cardUsuarios, 2, 0);
        tablaMetricas.Controls.Add(cardDevoluciones, 3, 0);
        tablaMetricas.Dock = DockStyle.Top;
        tablaMetricas.Location = new Point(0, 0);
        tablaMetricas.Name = "tablaMetricas";
        tablaMetricas.Padding = new Padding(14, 14, 14, 0);
        tablaMetricas.RowCount = 1;
        tablaMetricas.RowStyles.Add(new RowStyle(SizeType.Absolute, 132F));
        tablaMetricas.Size = new Size(900, 146);
        tablaMetricas.TabIndex = 0;
        // 
        // cardLibrosTotales
        // 
        cardLibrosTotales.Controls.Add(lblLibrosTotalesValor);
        cardLibrosTotales.Controls.Add(lblLibrosTotalesTitulo);
        cardLibrosTotales.Dock = DockStyle.Fill;
        cardLibrosTotales.Margin = new Padding(7);
        cardLibrosTotales.Name = "cardLibrosTotales";
        cardLibrosTotales.Padding = new Padding(14);
        cardLibrosTotales.TabIndex = 0;
        // 
        // lblLibrosTotalesTitulo
        // 
        lblLibrosTotalesTitulo.AutoSize = true;
        lblLibrosTotalesTitulo.Depth = 0;
        lblLibrosTotalesTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
        lblLibrosTotalesTitulo.Location = new Point(14, 14);
        lblLibrosTotalesTitulo.MouseState = MaterialSkin.MouseState.HOVER;
        lblLibrosTotalesTitulo.Name = "lblLibrosTotalesTitulo";
        lblLibrosTotalesTitulo.TabIndex = 0;
        lblLibrosTotalesTitulo.Text = "Libros totales";
        // 
        // lblLibrosTotalesValor
        // 
        lblLibrosTotalesValor.AutoSize = true;
        lblLibrosTotalesValor.Depth = 0;
        lblLibrosTotalesValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
        lblLibrosTotalesValor.Location = new Point(14, 54);
        lblLibrosTotalesValor.MouseState = MaterialSkin.MouseState.HOVER;
        lblLibrosTotalesValor.Name = "lblLibrosTotalesValor";
        lblLibrosTotalesValor.TabIndex = 1;
        lblLibrosTotalesValor.Text = "0";
        // 
        // cardPrestamosActivos
        // 
        cardPrestamosActivos.Controls.Add(lblPrestamosActivosValor);
        cardPrestamosActivos.Controls.Add(lblPrestamosActivosTitulo);
        cardPrestamosActivos.Dock = DockStyle.Fill;
        cardPrestamosActivos.Margin = new Padding(7);
        cardPrestamosActivos.Name = "cardPrestamosActivos";
        cardPrestamosActivos.Padding = new Padding(14);
        cardPrestamosActivos.TabIndex = 1;
        // 
        // lblPrestamosActivosTitulo
        // 
        lblPrestamosActivosTitulo.AutoSize = true;
        lblPrestamosActivosTitulo.Depth = 0;
        lblPrestamosActivosTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
        lblPrestamosActivosTitulo.Location = new Point(14, 14);
        lblPrestamosActivosTitulo.MouseState = MaterialSkin.MouseState.HOVER;
        lblPrestamosActivosTitulo.Name = "lblPrestamosActivosTitulo";
        lblPrestamosActivosTitulo.TabIndex = 0;
        lblPrestamosActivosTitulo.Text = "Préstamos activos";
        // 
        // lblPrestamosActivosValor
        // 
        lblPrestamosActivosValor.AutoSize = true;
        lblPrestamosActivosValor.Depth = 0;
        lblPrestamosActivosValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
        lblPrestamosActivosValor.Location = new Point(14, 54);
        lblPrestamosActivosValor.MouseState = MaterialSkin.MouseState.HOVER;
        lblPrestamosActivosValor.Name = "lblPrestamosActivosValor";
        lblPrestamosActivosValor.TabIndex = 1;
        lblPrestamosActivosValor.Text = "0";
        // 
        // cardUsuarios
        // 
        cardUsuarios.Controls.Add(lblUsuariosValor);
        cardUsuarios.Controls.Add(lblUsuariosTitulo);
        cardUsuarios.Dock = DockStyle.Fill;
        cardUsuarios.Margin = new Padding(7);
        cardUsuarios.Name = "cardUsuarios";
        cardUsuarios.Padding = new Padding(14);
        cardUsuarios.TabIndex = 2;
        // 
        // lblUsuariosTitulo
        // 
        lblUsuariosTitulo.AutoSize = true;
        lblUsuariosTitulo.Depth = 0;
        lblUsuariosTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
        lblUsuariosTitulo.Location = new Point(14, 14);
        lblUsuariosTitulo.MouseState = MaterialSkin.MouseState.HOVER;
        lblUsuariosTitulo.Name = "lblUsuariosTitulo";
        lblUsuariosTitulo.TabIndex = 0;
        lblUsuariosTitulo.Text = "Usuarios";
        // 
        // lblUsuariosValor
        // 
        lblUsuariosValor.AutoSize = true;
        lblUsuariosValor.Depth = 0;
        lblUsuariosValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
        lblUsuariosValor.Location = new Point(14, 54);
        lblUsuariosValor.MouseState = MaterialSkin.MouseState.HOVER;
        lblUsuariosValor.Name = "lblUsuariosValor";
        lblUsuariosValor.TabIndex = 1;
        lblUsuariosValor.Text = "0";
        // 
        // cardDevoluciones
        // 
        cardDevoluciones.Controls.Add(lblDevolucionesValor);
        cardDevoluciones.Controls.Add(lblDevolucionesTitulo);
        cardDevoluciones.Dock = DockStyle.Fill;
        cardDevoluciones.Margin = new Padding(7);
        cardDevoluciones.Name = "cardDevoluciones";
        cardDevoluciones.Padding = new Padding(14);
        cardDevoluciones.TabIndex = 3;
        // 
        // lblDevolucionesTitulo
        // 
        lblDevolucionesTitulo.AutoSize = true;
        lblDevolucionesTitulo.Depth = 0;
        lblDevolucionesTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
        lblDevolucionesTitulo.Location = new Point(14, 14);
        lblDevolucionesTitulo.MouseState = MaterialSkin.MouseState.HOVER;
        lblDevolucionesTitulo.Name = "lblDevolucionesTitulo";
        lblDevolucionesTitulo.TabIndex = 0;
        lblDevolucionesTitulo.Text = "Devoluciones";
        // 
        // lblDevolucionesValor
        // 
        lblDevolucionesValor.AutoSize = true;
        lblDevolucionesValor.Depth = 0;
        lblDevolucionesValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
        lblDevolucionesValor.Location = new Point(14, 54);
        lblDevolucionesValor.MouseState = MaterialSkin.MouseState.HOVER;
        lblDevolucionesValor.Name = "lblDevolucionesValor";
        lblDevolucionesValor.TabIndex = 1;
        lblDevolucionesValor.Text = "0";
        // 
        // cardActividadesRecientes
        // 
        cardActividadesRecientes.Controls.Add(pnlEstadoVacio);
        cardActividadesRecientes.Controls.Add(lblActividadesTitulo);
        cardActividadesRecientes.Dock = DockStyle.Fill;
        cardActividadesRecientes.Margin = new Padding(21, 14, 21, 21);
        cardActividadesRecientes.Name = "cardActividadesRecientes";
        cardActividadesRecientes.Padding = new Padding(14);
        cardActividadesRecientes.TabIndex = 1;
        // 
        // lblActividadesTitulo
        // 
        lblActividadesTitulo.AutoSize = true;
        lblActividadesTitulo.Depth = 0;
        lblActividadesTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
        lblActividadesTitulo.Location = new Point(14, 14);
        lblActividadesTitulo.MouseState = MaterialSkin.MouseState.HOVER;
        lblActividadesTitulo.Name = "lblActividadesTitulo";
        lblActividadesTitulo.TabIndex = 0;
        lblActividadesTitulo.Text = "Actividades recientes";
        //
        // PANEL ESTADO VACÍO
        //
        pnlEstadoVacio.Controls.Add(lblSubtituloEstado);
        pnlEstadoVacio.Controls.Add(lblTituloEstado);
        pnlEstadoVacio.Controls.Add(lblIconoEstado);
        pnlEstadoVacio.Dock = DockStyle.Fill;
        pnlEstadoVacio.Location = new Point(14, 48);
        pnlEstadoVacio.Name = "pnlEstadoVacio";
        pnlEstadoVacio.Padding = new Padding(20, 18, 20, 18);
        pnlEstadoVacio.Size = new Size(822, 350);
        pnlEstadoVacio.TabIndex = 1;

        //
        // ICONO DEL ESTADO VACÍO
        //
        lblIconoEstado.AutoSize = false;
        lblIconoEstado.Dock = DockStyle.Top;
        lblIconoEstado.Depth = 0;
        lblIconoEstado.Font = new Font("Roboto", 34F, FontStyle.Regular, GraphicsUnit.Pixel);
        lblIconoEstado.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
        lblIconoEstado.Height = 58;
        lblIconoEstado.MouseState = MaterialSkin.MouseState.HOVER;
        lblIconoEstado.Name = "lblIconoEstado";
        lblIconoEstado.TabIndex = 0;
        lblIconoEstado.Text = "▱";
        lblIconoEstado.TextAlign = ContentAlignment.MiddleCenter;

        //
        // TÍTULO DEL ESTADO VACÍO
        //
        lblTituloEstado.AutoEllipsis = true;
        lblTituloEstado.AutoSize = false;
        lblTituloEstado.Dock = DockStyle.Top;
        lblTituloEstado.Depth = 0;
        lblTituloEstado.Font = new Font("Roboto", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
        lblTituloEstado.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
        lblTituloEstado.Height = 34;
        lblTituloEstado.MouseState = MaterialSkin.MouseState.HOVER;
        lblTituloEstado.Name = "lblTituloEstado";
        lblTituloEstado.TabIndex = 1;
        lblTituloEstado.Text = "Tu biblioteca está lista";
        lblTituloEstado.TextAlign = ContentAlignment.MiddleCenter;

        //
        // SUBTÍTULO DEL ESTADO VACÍO
        //
        lblSubtituloEstado.AutoEllipsis = true;
        lblSubtituloEstado.AutoSize = false;
        lblSubtituloEstado.Dock = DockStyle.Fill;
        lblSubtituloEstado.Depth = 0;
        lblSubtituloEstado.FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
        lblSubtituloEstado.MouseState = MaterialSkin.MouseState.HOVER;
        lblSubtituloEstado.Name = "lblSubtituloEstado";
        lblSubtituloEstado.TabIndex = 2;
        lblSubtituloEstado.Text = "Aquí verás los préstamos recientes en cuanto se registren las primeras transacciones";
        lblSubtituloEstado.TextAlign = ContentAlignment.TopCenter;
        // 
        // UcDashboard
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(cardActividadesRecientes);
        Controls.Add(tablaMetricas);
        Name = "UcDashboard";
        Size = new Size(900, 586);
        tablaMetricas.ResumeLayout(false);
        cardLibrosTotales.ResumeLayout(false);
        cardLibrosTotales.PerformLayout();
        cardPrestamosActivos.ResumeLayout(false);
        cardPrestamosActivos.PerformLayout();
        cardUsuarios.ResumeLayout(false);
        cardUsuarios.PerformLayout();
        cardDevoluciones.ResumeLayout(false);
        cardDevoluciones.PerformLayout();
        cardActividadesRecientes.ResumeLayout(false);
        cardActividadesRecientes.PerformLayout();
        pnlEstadoVacio.ResumeLayout(false);
        ResumeLayout(false);
    }

    private TableLayoutPanel tablaMetricas;
    private MaterialSkin.Controls.MaterialCard cardLibrosTotales;
    private MaterialSkin.Controls.MaterialCard cardPrestamosActivos;
    private MaterialSkin.Controls.MaterialCard cardUsuarios;
    private MaterialSkin.Controls.MaterialCard cardDevoluciones;
    private MaterialSkin.Controls.MaterialCard cardActividadesRecientes;
    private MaterialSkin.Controls.MaterialLabel lblLibrosTotalesTitulo;
    private MaterialSkin.Controls.MaterialLabel lblLibrosTotalesValor;
    private MaterialSkin.Controls.MaterialLabel lblPrestamosActivosTitulo;
    private MaterialSkin.Controls.MaterialLabel lblPrestamosActivosValor;
    private MaterialSkin.Controls.MaterialLabel lblUsuariosTitulo;
    private MaterialSkin.Controls.MaterialLabel lblUsuariosValor;
    private MaterialSkin.Controls.MaterialLabel lblDevolucionesTitulo;
    private MaterialSkin.Controls.MaterialLabel lblDevolucionesValor;
    private MaterialSkin.Controls.MaterialLabel lblActividadesTitulo;
    private Panel pnlEstadoVacio;
    private MaterialSkin.Controls.MaterialLabel lblIconoEstado;
    private MaterialSkin.Controls.MaterialLabel lblTituloEstado;
    private MaterialSkin.Controls.MaterialLabel lblSubtituloEstado;
}
