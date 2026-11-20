#nullable enable

using System.ComponentModel;

namespace Examen_Cafeteria_ViancaMaldonado;

partial class frmPedidos
{
    private IContainer? components;
    private Label lblClienteTitulo = null!;
    private TextBox txtCliente = null!;
    private CheckBox chkFrecuente = null!;
    private Label lblFechaTitulo = null!;
    private DateTimePicker dtpFecha = null!;
    private Label lblProductoTitulo = null!;
    private TextBox txtProducto = null!;
    private Label lblPrecioTitulo = null!;
    private TextBox txtPrecio = null!;
    private Label lblCantidadTitulo = null!;
    private NumericUpDown nudCantidad = null!;
    private GroupBox grpTamano = null!;
    private RadioButton rbtNormal = null!;
    private RadioButton rbtGrande = null!;
    private GroupBox grpServicio = null!;
    private RadioButton rbtLocal = null!;
    private RadioButton rbtLlevar = null!;
    private CheckBox chkPorcionExtra = null!;
    private Button btnCalcular = null!;
    private Button btnLimpiar = null!;
    private Button btnSalir = null!;
    private Button btnAgregar = null!;
    private Label lblEncabezado = null!;
    private ListBox lstPedido = null!;
    private Label lblSubtotalTitulo = null!;
    private Label lblDescuentoTitulo = null!;
    private Label lblEmpaqueTitulo = null!;
    private Label lblItbisTitulo = null!;
    private Label lblTotalTitulo = null!;
    private Label lblSubtotal = null!;
    private Label lblDescuento = null!;
    private Label lblEmpaque = null!;
    private Label lblItbis = null!;
    private Label lblTotal = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new Container();
        lblClienteTitulo = CrearEtiqueta("Cliente:", 30, 40, 100);
        txtCliente = new TextBox();
        chkFrecuente = new CheckBox();
        lblFechaTitulo = CrearEtiqueta("Fecha:", 30, 106, 100);
        dtpFecha = new DateTimePicker();
        lblProductoTitulo = CrearEtiqueta("Producto:", 30, 160, 100);
        txtProducto = new TextBox();
        lblPrecioTitulo = CrearEtiqueta("Precio:", 30, 214, 100);
        txtPrecio = new TextBox();
        lblCantidadTitulo = CrearEtiqueta("Cantidad:", 30, 268, 100);
        nudCantidad = new NumericUpDown();
        grpTamano = new GroupBox();
        rbtNormal = new RadioButton();
        rbtGrande = new RadioButton();
        grpServicio = new GroupBox();
        rbtLocal = new RadioButton();
        rbtLlevar = new RadioButton();
        chkPorcionExtra = new CheckBox();
        btnCalcular = new Button();
        btnLimpiar = new Button();
        btnSalir = new Button();
        btnAgregar = new Button();
        lblEncabezado = new Label();
        lstPedido = new ListBox();
        lblSubtotalTitulo = CrearEtiqueta("Subtotal", 650, 386, 145);
        lblDescuentoTitulo = CrearEtiqueta("Descuento", 650, 425, 145);
        lblEmpaqueTitulo = CrearEtiqueta("Empaque", 650, 464, 145);
        lblItbisTitulo = CrearEtiqueta("ITBIS (18 %)", 650, 503, 145);
        lblTotalTitulo = CrearEtiqueta("TOTAL A PAGAR", 650, 564, 150, true);
        lblSubtotal = CrearImporte(380, false);
        lblDescuento = CrearImporte(419, false);
        lblEmpaque = CrearImporte(458, false);
        lblItbis = CrearImporte(497, false);
        lblTotal = CrearImporte(557, true);
        ((ISupportInitialize)nudCantidad).BeginInit();
        grpTamano.SuspendLayout();
        grpServicio.SuspendLayout();
        SuspendLayout();

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(239, 230, 250);
        ForeColor = Color.FromArgb(72, 58, 93);
        ClientSize = new Size(1120, 670);
        MinimumSize = new Size(1050, 620);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Cafetería El Buen Sabor - Pedidos";

        txtCliente.Font = new Font("Segoe UI", 11F);
        txtCliente.Location = new Point(150, 34);
        txtCliente.Name = "txtCliente";
        txtCliente.Size = new Size(390, 27);
        chkFrecuente.AutoSize = true;
        chkFrecuente.Font = new Font("Segoe UI", 10F);
        chkFrecuente.Location = new Point(54, 75);
        chkFrecuente.Name = "chkFrecuente";
        chkFrecuente.Text = "Cliente frecuente";
        dtpFecha.Font = new Font("Segoe UI", 10F);
        dtpFecha.Format = DateTimePickerFormat.Custom;
        dtpFecha.CustomFormat = "dd/MM/yyyy";
        dtpFecha.Location = new Point(150, 101);
        dtpFecha.Name = "dtpFecha";
        dtpFecha.Size = new Size(390, 25);
        txtProducto.Font = new Font("Segoe UI", 11F);
        txtProducto.Location = new Point(150, 155);
        txtProducto.Name = "txtProducto";
        txtProducto.Size = new Size(390, 27);
        txtPrecio.Font = new Font("Segoe UI", 11F);
        txtPrecio.Location = new Point(150, 209);
        txtPrecio.Name = "txtPrecio";
        txtPrecio.Size = new Size(390, 27);
        nudCantidad.Font = new Font("Segoe UI", 11F);
        nudCantidad.Location = new Point(150, 263);
        nudCantidad.Maximum = new decimal(new[] { 20, 0, 0, 0 });
        nudCantidad.Minimum = new decimal(new[] { 1, 0, 0, 0 });
        nudCantidad.Name = "nudCantidad";
        nudCantidad.Size = new Size(215, 27);
        nudCantidad.Value = new decimal(new[] { 1, 0, 0, 0 });

        grpTamano.BackColor = Color.FromArgb(232, 217, 248);
        grpTamano.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpTamano.ForeColor = Color.FromArgb(82, 61, 112);
        grpTamano.Location = new Point(30, 315);
        grpTamano.Name = "grpTamano";
        grpTamano.Size = new Size(278, 150);
        grpTamano.TabStop = false;
        grpTamano.Text = "Tamaño";
        grpTamano.Controls.AddRange(new Control[] { rbtNormal, rbtGrande });
        rbtNormal.AutoSize = true;
        rbtNormal.Checked = true;
        rbtNormal.Font = new Font("Segoe UI", 10F);
        rbtNormal.Location = new Point(17, 39);
        rbtNormal.Name = "rbtNormal";
        rbtNormal.TabStop = true;
        rbtNormal.Text = "Normal";
        rbtGrande.AutoSize = true;
        rbtGrande.Font = new Font("Segoe UI", 10F);
        rbtGrande.Location = new Point(17, 91);
        rbtGrande.Name = "rbtGrande";
        rbtGrande.Text = "Grande (+RD$25)";

        grpServicio.BackColor = Color.FromArgb(232, 217, 248);
        grpServicio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpServicio.ForeColor = Color.FromArgb(82, 61, 112);
        grpServicio.Location = new Point(326, 315);
        grpServicio.Name = "grpServicio";
        grpServicio.Size = new Size(278, 150);
        grpServicio.TabStop = false;
        grpServicio.Text = "Servicio";
        grpServicio.Controls.AddRange(new Control[] { rbtLocal, rbtLlevar });
        rbtLocal.AutoSize = true;
        rbtLocal.Checked = true;
        rbtLocal.Font = new Font("Segoe UI", 10F);
        rbtLocal.Location = new Point(16, 39);
        rbtLocal.Name = "rbtLocal";
        rbtLocal.TabStop = true;
        rbtLocal.Text = "Consumir en local";
        rbtLlevar.AutoSize = true;
        rbtLlevar.Font = new Font("Segoe UI", 10F);
        rbtLlevar.Location = new Point(16, 91);
        rbtLlevar.Name = "rbtLlevar";
        rbtLlevar.Text = "Para llevar (+RD$20)";

        chkPorcionExtra.AutoSize = true;
        chkPorcionExtra.Font = new Font("Segoe UI", 10F);
        chkPorcionExtra.Location = new Point(34, 485);
        chkPorcionExtra.Name = "chkPorcionExtra";
        chkPorcionExtra.Text = "Porción extra (+RD$30)";

        EstilizarBoton(btnCalcular, "Calcular total", "btnCalcular", new Point(30, 548), new Size(190, 62), Color.FromArgb(207, 183, 235), Color.FromArgb(64, 46, 91));
        EstilizarBoton(btnLimpiar, "Nuevo pedido", "btnLimpiar", new Point(230, 548), new Size(190, 62), Color.FromArgb(221, 207, 242), Color.FromArgb(64, 46, 91));
        EstilizarBoton(btnSalir, "Salir", "btnSalir", new Point(430, 548), new Size(150, 62), Color.FromArgb(229, 215, 243), Color.FromArgb(77, 57, 101));
        EstilizarBoton(btnAgregar, "Agregar al pedido", "btnAgregar", new Point(650, 32), new Size(440, 58), Color.FromArgb(201, 181, 232), Color.FromArgb(64, 46, 91));

        lblEncabezado.Font = new Font("Consolas", 10F, FontStyle.Bold);
        lblEncabezado.ForeColor = Color.FromArgb(82, 61, 112);
        lblEncabezado.Location = new Point(650, 100);
        lblEncabezado.Name = "lblEncabezado";
        lblEncabezado.Size = new Size(440, 25);
        lblEncabezado.Text = "Cant".PadRight(6) + "Producto".PadRight(24) + "Precio".PadLeft(10) + "Total".PadLeft(12);
        lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;

        lstPedido.BackColor = Color.White;
        lstPedido.BorderStyle = BorderStyle.FixedSingle;
        lstPedido.Font = new Font("Consolas", 10F);
        lstPedido.ForeColor = Color.FromArgb(45, 45, 45);
        lstPedido.FormattingEnabled = true;
        lstPedido.HorizontalScrollbar = true;
        lstPedido.ItemHeight = 18;
        lstPedido.Location = new Point(650, 128);
        lstPedido.Name = "lstPedido";
        lstPedido.Size = new Size(440, 220);

        Controls.AddRange(new Control[]
        {
            lblClienteTitulo, txtCliente, chkFrecuente, lblFechaTitulo, dtpFecha,
            lblProductoTitulo, txtProducto, lblPrecioTitulo, txtPrecio, lblCantidadTitulo,
            nudCantidad, grpTamano, grpServicio, chkPorcionExtra, btnCalcular, btnLimpiar,
            btnSalir, btnAgregar, lblEncabezado, lstPedido, lblSubtotalTitulo,
            lblDescuentoTitulo, lblEmpaqueTitulo, lblItbisTitulo, lblTotalTitulo,
            lblSubtotal, lblDescuento, lblEmpaque, lblItbis, lblTotal
        });

        ((ISupportInitialize)nudCantidad).EndInit();
        grpTamano.ResumeLayout(false);
        grpTamano.PerformLayout();
        grpServicio.ResumeLayout(false);
        grpServicio.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private static Label CrearEtiqueta(string texto, int x, int y, int ancho, bool bold = false)
    {
        return new Label
        {
            AutoSize = false,
            Font = new Font("Segoe UI", bold ? 10F : 11F, bold ? FontStyle.Bold : FontStyle.Regular),
            Location = new Point(x, y),
            Size = new Size(ancho, 28),
            Text = texto,
            TextAlign = ContentAlignment.MiddleLeft
        };
    }

    private static Label CrearImporte(int y, bool highlighted)
    {
        return new Label
        {
            AutoSize = false,
            BackColor = highlighted ? Color.FromArgb(221, 204, 242) : Color.White,
            BorderStyle = BorderStyle.FixedSingle,
            Font = new Font("Segoe UI", highlighted ? 11F : 10F, highlighted ? FontStyle.Bold : FontStyle.Regular),
            ForeColor = Color.FromArgb(35, 35, 35),
            Location = new Point(810, y),
            Size = new Size(145, highlighted ? 36 : 31),
            Text = "RD$ 0.00",
            TextAlign = ContentAlignment.MiddleRight
        };
    }

    private static void EstilizarBoton(Button button, string text, string name, Point location, Size size, Color backColor, Color foreColor)
    {
        button.BackColor = backColor;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        button.ForeColor = foreColor;
        button.Location = location;
        button.Name = name;
        button.Size = size;
        button.Text = text;
        button.UseVisualStyleBackColor = false;
    }
}
