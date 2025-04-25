namespace MonitorInvoiceApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {


            // Valida que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(txtInvoiceNumber.Text) ||
                string.IsNullOrWhiteSpace(txtInvoiceData.Text) ||
                string.IsNullOrWhiteSpace(txtCompanyName.Text) ||
                string.IsNullOrWhiteSpace(txtAddresLine1.Text))
            {
                MessageBox.Show("Ingrese todos los campos obligatorios (*) antes de continuar.");
                return;
            }

            if ((string.IsNullOrWhiteSpace(txtPrice24.Text) || string.IsNullOrWhiteSpace(txtQuantity24.Text)) &&
               (string.IsNullOrWhiteSpace(txtPrice27.Text) || string.IsNullOrWhiteSpace(txtQuantity27.Text)) &&
               (string.IsNullOrWhiteSpace(txtPrice32.Text) || string.IsNullOrWhiteSpace(txtQuantity32.Text)))
            {
                MessageBox.Show("Ingrese cantidad y precio del producto selecionado antes de continuar.");
                return;
            }

            // Capturar los valores si pasaron la validación
            string InvoNum = txtInvoiceNumber.Text;
            string Invodata = txtInvoiceData.Text;
            string CompanyName = txtCompanyName.Text;
            string Addres1 = txtAddresLine1.Text;
            string Addres2 = txtAddresLine2.Text; // No obligatorio

            double precio24 = string.IsNullOrWhiteSpace(txtPrice24.Text) ? 0 : double.Parse(txtPrice24.Text);
            double precio27 = string.IsNullOrWhiteSpace(txtPrice27.Text) ? 0 : double.Parse(txtPrice27.Text);
            double precio32 = string.IsNullOrWhiteSpace(txtPrice32.Text) ? 0 : double.Parse(txtPrice32.Text);

            double cantidad24 = string.IsNullOrWhiteSpace(txtPrice24.Text) ? 0 : double.Parse(txtQuantity24.Text);
            double cantidad27 = string.IsNullOrWhiteSpace(txtPrice27.Text) ? 0 : double.Parse(txtQuantity27.Text);
            double cantidad32 = string.IsNullOrWhiteSpace(txtPrice32.Text) ? 0 : double.Parse(txtQuantity32.Text);


            //Calcular el valor Totals
            double totals1 = precio24 * cantidad24;
            double totals2 = precio27 * cantidad27;
            double totals3 = precio32 * cantidad32;

            txtTotals24.Text = totals1.ToString("F2");
            txtTotals27.Text = totals2.ToString("F2");
            txtTotals32.Text = totals3.ToString("F2");

            double Subtotal = totals1 + totals2 + totals3;
            double TaxRate = 0.16;
            double Taxes = Subtotal * TaxRate;
            double total = Subtotal + Taxes;

            lblSubTotal.Text = Subtotal.ToString("F2");
            lblTaxes.Text = Taxes.ToString("F2");
            lblTotal.Text = total.ToString("F2");


        }


        private void txtTotals24_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCompanyName.Clear();
            txtAddresLine1.Clear();
            txtAddresLine2.Clear();
            txtInvoiceData.Clear();
            txtInvoiceNumber.Clear();
            txtPrice24.Clear();
            txtPrice27.Clear();
            txtPrice32.Clear();
            txtQuantity24.Clear();
            txtQuantity27.Clear();
            txtQuantity32.Clear();
            txtTotals24.Clear();
            txtTotals27.Clear();
            txtTotals32.Clear();
            lblSubTotal.Text = "";
            lblTaxes.Text = "";
            lblTotal.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su mensaje se a guardado correctamente");
            txtCompanyName.Clear();
            txtAddresLine1.Clear();
            txtAddresLine2.Clear();
            txtInvoiceData.Clear();
            txtInvoiceNumber.Clear();
            txtPrice24.Clear();
            txtPrice27.Clear();
            txtPrice32.Clear();
            txtQuantity24.Clear();
            txtQuantity27.Clear();
            txtQuantity32.Clear();
            txtTotals24.Clear();
            txtTotals27.Clear();
            txtTotals32.Clear();
            lblSubTotal.Text = "";
            lblTaxes.Text = "";
            lblTotal.Text = "";

        }
    }
}
