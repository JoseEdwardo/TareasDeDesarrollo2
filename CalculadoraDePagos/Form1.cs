using Microsoft.VisualBasic;

namespace CalculadoraDePagos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Intentar convertir los valores de los TextBox
                if (!double.TryParse(textBox1.Text, out double monto) ||
                    !int.TryParse(textBox2.Text, out int meses) ||
                    !double.TryParse(textBox3.Text, out double tasaInteres))
                {
                    MessageBox.Show("Error: Ingrese números en los campos requeridos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convertir la tasa de interés de porcentaje a decimal
                tasaInteres /= 100;

                // Calcular la tasa mensual
                double tasaMensual = tasaInteres / 12;

                // Verificar si los valores son válidos
                if (monto <= 0 || meses <= 0 || tasaInteres < 0)
                {
                    MessageBox.Show("Error: Ingrese valores válidos y positivos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Determinar el tipo de pago (anticipado o no)
                Microsoft.VisualBasic.DueDate tipoPago = checkBox1.Checked
                    ? Microsoft.VisualBasic.DueDate.BegOfPeriod
                    : Microsoft.VisualBasic.DueDate.EndOfPeriod;

                // Calcular el pago mensual usando Financial.Pmt
                double pagoMensual = Math.Abs(Financial.Pmt(tasaMensual, meses, -monto, 0, tipoPago));

                // Mostrar el resultado en el label3
                label3.Text = "Pagos Mensuales: $" + pagoMensual.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
