namespace Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento para añadir un elemento a listBox1
        private void button1_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el elemento:", "Añadir Elemento", "");
            if (!string.IsNullOrWhiteSpace(input)) // Verifica que no esté vacío
            {
                listBox1.Items.Add(input);
            }
        }

        // Evento para borrar un elemento seleccionado en listBox1
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        // Evento para borrar toda la lista de listBox1
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        // Evento para añadir un elemento a listBox2 (ordenado automáticamente)
        private void button8_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el elemento:", "Añadir Elemento", "");
            if (!string.IsNullOrWhiteSpace(input))
            {
                listBox2.Items.Add(input);
                OrdenarLista(listBox2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<object> seleccionados = listBox2.SelectedItems.Cast<object>().ToList();
            foreach (var item in seleccionados)
            {
                listBox2.Items.Remove(item);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                OrdenarLista(listBox2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<object> seleccionados = listBox2.SelectedItems.Cast<object>().ToList();
            foreach (var item in seleccionados)
            {
                listBox1.Items.Add(item);
                listBox2.Items.Remove(item);
            }
        }

        // Método para ordenar los elementos de listBox2
        private void OrdenarLista(ListBox listBox)
        {
            List<string> elementos = listBox.Items.Cast<string>().ToList();
            elementos.Sort(); // se ordena alfabéticamente
            listBox.Items.Clear();
            foreach (string item in elementos)
            {
                listBox.Items.Add(item);
            }
        }
    }
}
