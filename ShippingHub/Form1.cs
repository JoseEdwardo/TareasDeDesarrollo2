using System.Windows.Forms.VisualStyles;

namespace ShippingHub
{
    public partial class Form1 : Form
    {
        private List<Package> packages = new List<Package>();
        private int currentIndex = -1;

        public Form1()
        {
            InitializeComponent();
            comboBoxState.Items.AddRange(new string[] { "Alabama", "Florida", "Georgia", "Kentucky", "Mississippi", "North Carolina", "South Carolina", "Tennessee", "West Virginia", "Virginia" });
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            EnableInputs(false);
            btnAdd.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void ActualizarEstadosEnComboBox() 
        {
            // Obtenemos los estados únicos de los paquetes
            var estadosUnicos = packages
                .Select(p => p.State)
                .Distinct()
                .OrderBy(e => e)
                .ToList();

            // Limpiamos y actualizamos el comboBox
            comboBoxFilterByState.Items.Clear();
            comboBoxFilterByState.Items.AddRange(estadosUnicos.ToArray());
        }

        private void btnScanNew_Click(object sender, EventArgs e)
        {
            Package pkg = new Package();
            packages.Add(pkg);
            currentIndex = packages.Count - 1;

            labelPackageID.Text = pkg.PackageNumber.ToString();
            labelArrivedAt.Text = DateTime.Now.ToString("g"); // fecha y hora

            txtAddress.Text = "";
            txtCity.Text = "";
            txtZip.Text = "";
            comboBoxState.SelectedIndex = -1;

            EnableInputs(true);
            btnAdd.Enabled = true;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void ShowPackage(int index)
        {
            if (index >= 0 && index < packages.Count)
            {
                Package pkg = packages[index];
                labelPackageID.Text = pkg.PackageNumber.ToString();
                labelArrivedAt.Text = DateTime.Now.ToString(); // o puedes guardar esto también en la clase
                txtAddress.Text = pkg.Address;
                txtCity.Text = pkg.City;
                txtZip.Text = pkg.Zip.ToString();
                comboBoxState.SelectedItem = pkg.State;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < packages.Count - 1)
            {
                SaveCurrentPackage();
                currentIndex++;
                ShowPackage(currentIndex);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                SaveCurrentPackage();
                currentIndex--;
                ShowPackage(currentIndex);
            }
        }

        private void SaveCurrentPackage()
        {
            if (currentIndex >= 0 && currentIndex < packages.Count)
            {
                Package pkg = packages[currentIndex];
                pkg.Address = txtAddress.Text;
                pkg.City = txtCity.Text;
                pkg.Zip = int.TryParse(txtZip.Text, out int zipVal) ? zipVal.ToString() : "0";
                pkg.State = comboBoxState.SelectedItem?.ToString();
            }
        }

        private void EnableInputs(bool enabled)
        {
            txtAddress.Enabled = enabled;
            txtCity.Enabled = enabled;
            txtZip.Enabled = enabled;
            comboBoxState.Enabled = enabled;
        }

        private void listBoxPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBoxFilterByState.SelectedItem.ToString();
            listBoxPackages.Items.Clear();

            foreach (Package pkg in packages)
            {
                if (pkg.State == selectedState)
                    listBoxPackages.Items.Add(pkg.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            SaveCurrentPackage();
            ActualizarEstadosEnComboBox();
            //Resto del codigo

            // Agregar al listBox según el estado
            string state = packages[currentIndex].State;
            if (comboBoxFilterByState.SelectedItem?.ToString() == state)
            {
                listBoxPackages.Items.Add(packages[currentIndex].ToString());
            }

            btnAdd.Enabled = false;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnEdit.Enabled = true;
            btnRemove.Enabled = true;

            EnableInputs(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                EnableInputs(true);
                btnEdit.Text = "Update";
            }
            else // Update
            {
                if (!ValidarCampos()) return; // Validación primero
                SaveCurrentPackage();
                ActualizarEstadosEnComboBox();
                comboBoxFilterByState_SelectedIndexChanged(null, null); // refresca el listBox
                EnableInputs(false);
                btnEdit.Text = "Edit";
            }
        }

        private void comboBoxFilterByState_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPackages.Items.Clear();
            string selectedState = comboBoxFilterByState.SelectedItem?.ToString();

            foreach (Package pkg in packages)
            {
                if (pkg.State == selectedState)
                    listBoxPackages.Items.Add(pkg.ToString());
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < packages.Count)
            {
                if (currentIndex >= 0 && currentIndex < packages.Count)
                {
                    // Obtener el estado antes de eliminar
                    string removedState = packages[currentIndex].State;

                    // Eliminar el paquete
                    packages.RemoveAt(currentIndex);

                    // Ajustar el índice actual
                    if (packages.Count == 0)
                    {
                        currentIndex = -1;
                    }
                    else if (currentIndex >= packages.Count)
                    {
                        currentIndex = packages.Count - 1;
                    }

                    // Actualizar el listBox para el estado actual
                    comboBoxFilterByState_SelectedIndexChanged(null, null);

                    // Si aún hay paquetes, mostrar el siguiente/último
                    if (currentIndex >= 0)
                    {
                        ShowPackage(currentIndex);
                    }
                    else
                    {
                        ClearForm(); // Si no quedan paquetes, limpiar la interfaz
                    }

                    // Deshabilitar campos
                    EnableInputs(false);

                    // Ajustar botones según la existencia de paquetes
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = packages.Count > 0;
                    btnRemove.Enabled = packages.Count > 0;
                    btnBack.Enabled = packages.Count > 1;
                    btnNext.Enabled = packages.Count > 1;
                }
            }
        }

        private void ClearForm() 
        {

            labelPackageID.Text = "";
            labelArrivedAt.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtZip.Text = "";
            comboBoxState.SelectedIndex = -1;

        }

        private bool ValidarCampos() 
        {

            // Validación de Address
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return false;
            }

            // Validación de City
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("La ciudad no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                return false;
            }

            // Validación de State
            if (comboBoxState.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxState.Focus();
                return false;
            }

            // Validación de Zip
            if (!int.TryParse(txtZip.Text, out int zipVal) || txtZip.Text.Length != 5)
            {
                MessageBox.Show("El código ZIP debe ser un número de 5 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtZip.Focus();
                return false;
            }

            return true;

        }

        private void listBoxPackages_DoubleClick(object sender, EventArgs e) 
        {
            if (listBoxPackages.SelectedItem != null)
            {
                string selectedText = listBoxPackages.SelectedItem.ToString();

                // Extraemos el número de paquete desde el texto (por ejemplo: "#3 - Santiago, FL")
                int packageID = ExtraerPackageIDDesdeTexto(selectedText);

                // Buscamos el paquete con ese ID
                Package pkg = packages.FirstOrDefault(p => p.PackageNumber == packageID);

                if (pkg != null)
                {
                    string detalles = $"ID del Paquete: {pkg.PackageNumber}\n" +
                                      $"Dirección: {pkg.Address}\n" +
                                      $"Ciudad: {pkg.City}\n" +
                                      $"Estado: {pkg.State}\n" +
                                      $"ZIP: {pkg.Zip}";

                    MessageBox.Show(detalles, "Detalles del Paquete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private int ExtraerPackageIDDesdeTexto(string texto) 
        {
            if (texto.StartsWith("#")) 
            {
                int finID = texto.IndexOf(" ");
                string idStr = texto.Substring(1, finID - 1);
                if (int.TryParse(idStr, out int id)) 
                {
                    return id;
                }
            }
            return -1;
        }
    }
}
