namespace Flags
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> flags = new Dictionary<string, string>();
        List<string> flagKeys;
        int currentIndex = 0;
        int correctAnswers = 0;
        const int totalFlags = 35; // Número total de banderas a mostrar

        public Form1()
        {

            InitializeComponent();
            LoadFlags();
            ShuffleFlags();
            ShowFlag();
        }

        private void LoadFlags()
        {
            MessageBox.Show("Welcome to the Quiz Flags!");

            // Aquí agregas los pares clave/valor: nombre archivo imagen -> nombre del país
            flags.Add("usa", "United States");
            flags.Add("canada", "Canada");
            flags.Add("mexico", "Mexico");
            flags.Add("brazil", "Brazil");
            flags.Add("argentina", "Argentina");
            flags.Add("uk", "United Kingdom");
            flags.Add("france", "France");
            flags.Add("germany", "Germany");
            flags.Add("italy", "Italy");
            flags.Add("spain", "Spain");
            flags.Add("portugal", "Portugal");
            flags.Add("netherlands", "Netherlands");
            flags.Add("belgium", "Belgium");
            flags.Add("sweden", "Sweden");
            flags.Add("norway", "Norway");
            flags.Add("denmark", "Denmark");
            flags.Add("russia", "Russia");
            flags.Add("china", "China");
            flags.Add("japan", "Japan");
            flags.Add("southkorea", "South Korea");
            flags.Add("india", "India");
            flags.Add("pakistan", "Pakistan");
            flags.Add("australia", "Australia");
            flags.Add("newzealand", "New Zealand");
            flags.Add("southafrica", "South Africa");
            flags.Add("egypt", "Egypt");
            flags.Add("nigeria", "Nigeria");
            flags.Add("kenya", "Kenya");
            flags.Add("turkey", "Turkey");
            flags.Add("greece", "Greece");
            flags.Add("poland", "Poland");
            flags.Add("austria", "Austria");
            flags.Add("switzerland", "Switzerland");
            flags.Add("iran", "Iran");
            flags.Add("indonesia", "Indonesia");
            // Agrega hasta tener 35 banderas

            comboBoxCountries.Items.AddRange(flags.Values.ToArray());
            flagKeys = flags.Keys.ToList();


        }

        private void ShuffleFlags()
        {
            Random rand = new Random();
            flagKeys = flagKeys.OrderBy(f => rand.Next()).ToList();
        }

        private void ShowFlag()
        {
            if (currentIndex >= totalFlags || currentIndex >= flagKeys.Count)
            {
                // Fin del quiz
                comboBoxCountries.Enabled = false;
                buttonSubmit.Enabled = false;
                buttonNext.Enabled = false;

                ShowFinalResult();
                return;
            }

            string flagKey = flagKeys[currentIndex];
            pictureBoxFlag.Image = Image.FromFile($"flags/{flagKey}.png"); // Ruta de la imagen
            labelResult.Text = "";
            comboBoxCountries.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxCountries.SelectedItem == null)
            {
                MessageBox.Show("Please select a country.");
                return;
            }

            string selectedCountry = comboBoxCountries.SelectedItem.ToString();
            string correctCountry = flags[flagKeys[currentIndex]];

            if (selectedCountry == correctCountry)
            {
                labelResult.Text = "Correct!";
                correctAnswers++;
            }
            else
            {
                labelResult.Text = "Incorrect!";
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            ShowFlag();
        }

        private void ShowFinalResult()
        {
            string message;

            if (correctAnswers <= 5)
                message = "Fail";
            else if (correctAnswers <= 15)
                message = "Poor";
            else if (correctAnswers <= 20)
                message = "Good";
            else if (correctAnswers <= 34)
                message = "Very Good!";
            else
                message = "Excellent!";

            textBoxFinalResult.Text = message;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
