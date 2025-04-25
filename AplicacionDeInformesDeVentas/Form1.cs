using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AplicacionDeInformesDeVentas
{
    public partial class Form1 : Form
    {
        // Variable para almacenar el total de todas las ventas de la semana
        private decimal totalGrossSales = 0;

        public Form1()
        {
            InitializeComponent();

            // Configurar encabezados del ListBox simulando una tabla
            lstSales.Items.Add(" Name \tMon.\tTue.\tWed.\tThu.\tFri.\tTotal");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validación: Asegurar que el nombre del artículo no esté vacío
            if (string.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Variables para almacenar los valores de ventas diarias
            decimal monday, tuesday, wednesday, thursday, friday;

            // Intentar convertir los valores ingresados a decimales
            if (!decimal.TryParse(txtMonday.Text, out monday) ||
                !decimal.TryParse(txtTuesday.Text, out tuesday) ||
                !decimal.TryParse(txtWednesday.Text, out wednesday) ||
                !decimal.TryParse(txtThursday.Text, out thursday) ||
                !decimal.TryParse(txtFriday.Text, out friday))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para los días de la semana.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calcular el total de ventas del artículo en la semana
            decimal itemTotal = monday + tuesday + wednesday + thursday + friday;

            // Agregar el artículo y sus valores de ventas al ListBox con formato tabular
            lstSales.Items.Add($" {txtItem.Text} \t${monday:F2}\t${tuesday:F2}\t${wednesday:F2}\t${thursday:F2}\t${friday:F2}\t${itemTotal:F2}");

            // Sumar al total general de la semana
            totalGrossSales += itemTotal;
            lblGrossSales.Text = "$" + totalGrossSales.ToString("F2");

            // Limpiar los campos para ingresar otro artículo
            txtItem.Clear();
            txtMonday.Clear();
            txtTuesday.Clear();
            txtWednesday.Clear();
            txtThursday.Clear();
            txtFriday.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblGrossSales_Click(object sender, EventArgs e)
        {

        }
    }
}
