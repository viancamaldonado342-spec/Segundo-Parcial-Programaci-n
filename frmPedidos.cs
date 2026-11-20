using System.Globalization;

namespace Examen_Cafeteria_ViancaMaldonado;

public partial class frmPedidos : Form
{
    private decimal subtotalAcumulado;

    public frmPedidos()
    {
        InitializeComponent();
        Load += frmPedidos_Load;
        btnAgregar.Click += btnAgregar_Click;
        btnCalcular.Click += btnCalcular_Click;
        btnLimpiar.Click += btnLimpiar_Click;
        btnSalir.Click += btnSalir_Click;
    }

    private void frmPedidos_Load(object? sender, EventArgs e)
    {
        dtpFecha.Value = DateTime.Today;
        lblEncabezado.Text = "Cant".PadRight(6) + "Producto".PadRight(24) + "Precio".PadLeft(10) + "Total".PadLeft(12);
        lstPedido.Items.Clear();
        subtotalAcumulado = 0m;
        RestablecerResultados();
        rbtNormal.Checked = true;
        rbtLocal.Checked = true;
        nudCantidad.Value = 1;
    }

    private void btnAgregar_Click(object? sender, EventArgs e)
    {
        string nombreProducto = txtProducto.Text.Trim();
        if (nombreProducto.Length == 0)
        {
            MessageBox.Show("Escriba el nombre del producto.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtProducto.Focus();
            return;
        }

        if (!TryLeerPrecio(txtPrecio.Text, out decimal precioBase) || precioBase <= 0m)
        {
            MessageBox.Show("Digite un precio válido mayor que cero.", "Precio inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPrecio.Focus();
            txtPrecio.SelectAll();
            return;
        }

        decimal precioUnitario = precioBase;
        string detalleProducto = nombreProducto;
        if (rbtGrande.Checked)
        {
            precioUnitario += 25m;
            detalleProducto += " (Grande)";
        }

        if (chkPorcionExtra.Checked)
        {
            precioUnitario += 30m;
            detalleProducto += " (Extra)";
        }

        int cantidad = decimal.ToInt32(nudCantidad.Value);
        decimal totalLinea = precioUnitario * cantidad;
        string linea = cantidad.ToString(CultureInfo.InvariantCulture).PadRight(6)
            + detalleProducto.PadRight(24)
            + FormatearDinero(precioUnitario).PadLeft(10)
            + FormatearDinero(totalLinea).PadLeft(12);

        lstPedido.Items.Add(linea);
        subtotalAcumulado += totalLinea;
        lblSubtotal.Text = FormatearEtiqueta(subtotalAcumulado);
        lblDescuento.Text = FormatearEtiqueta(0m);
        lblEmpaque.Text = FormatearEtiqueta(0m);
        lblItbis.Text = FormatearEtiqueta(0m);
        lblTotal.Text = FormatearEtiqueta(0m);

        txtProducto.Clear();
        txtPrecio.Clear();
        nudCantidad.Value = 1;
        rbtNormal.Checked = true;
        chkPorcionExtra.Checked = false;
        txtProducto.Focus();
    }

    private void btnCalcular_Click(object? sender, EventArgs e)
    {
        if (lstPedido.Items.Count == 0)
        {
            MessageBox.Show("Agregue al menos un producto antes de calcular el total.", "Pedido vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtProducto.Focus();
            return;
        }

        decimal descuento = chkFrecuente.Checked
            ? decimal.Round(subtotalAcumulado * 0.10m, 2, MidpointRounding.AwayFromZero)
            : 0m;
        decimal empaque = rbtLlevar.Checked ? 20m : 0m;
        decimal baseImponible = subtotalAcumulado - descuento + empaque;
        decimal itbis = decimal.Round(baseImponible * 0.18m, 2, MidpointRounding.AwayFromZero);
        decimal total = baseImponible + itbis;

        lblSubtotal.Text = FormatearEtiqueta(subtotalAcumulado);
        lblDescuento.Text = FormatearEtiqueta(descuento);
        lblEmpaque.Text = FormatearEtiqueta(empaque);
        lblItbis.Text = FormatearEtiqueta(itbis);
        lblTotal.Text = FormatearEtiqueta(total);
    }

    private void btnLimpiar_Click(object? sender, EventArgs e)
    {
        txtCliente.Clear();
        chkFrecuente.Checked = false;
        dtpFecha.Value = DateTime.Today;
        txtProducto.Clear();
        txtPrecio.Clear();
        nudCantidad.Value = 1;
        rbtNormal.Checked = true;
        rbtLocal.Checked = true;
        chkPorcionExtra.Checked = false;
        lstPedido.Items.Clear();
        subtotalAcumulado = 0m;
        RestablecerResultados();
        txtCliente.Focus();
    }

    private void btnSalir_Click(object? sender, EventArgs e)
    {
        DialogResult respuesta = MessageBox.Show(
            "¿Está seguro de que desea salir?",
            "Confirmar salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

        if (respuesta == DialogResult.Yes)
        {
            Close();
        }
    }

    private void RestablecerResultados()
    {
        lblSubtotal.Text = FormatearEtiqueta(0m);
        lblDescuento.Text = FormatearEtiqueta(0m);
        lblEmpaque.Text = FormatearEtiqueta(0m);
        lblItbis.Text = FormatearEtiqueta(0m);
        lblTotal.Text = FormatearEtiqueta(0m);
    }

    private static bool TryLeerPrecio(string texto, out decimal precio)
    {
        const NumberStyles estilos = NumberStyles.Number;
        string valor = texto.Trim();
        return decimal.TryParse(valor, estilos, CultureInfo.InvariantCulture, out precio)
            || decimal.TryParse(valor, estilos, CultureInfo.CurrentCulture, out precio);
    }

    private static string FormatearDinero(decimal valor) => valor.ToString("0.00", CultureInfo.InvariantCulture);

    private static string FormatearEtiqueta(decimal valor) => "RD$ " + FormatearDinero(valor);
}
