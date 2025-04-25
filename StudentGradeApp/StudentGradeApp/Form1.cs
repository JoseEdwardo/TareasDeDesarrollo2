namespace StudentGradeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declarar un arreglo bidimensional para almacenar los nombres
        //de los estudiantes y su promedio
        string[,] estudiantes = new string[10, 2];

        //constantes para indicar las columnas nombre y promedio
        const int nombre = 0;
        const int promedio = 1;

        //variable para almacenar la cantidad de estudiantes introducidos
        int contadorEstudiantes = 0;

        //Metodo para calcular el promedio de un estudiante
        public double CalcularPromedioEstudiante(double test1, double test2, double test3)
        {
            return (test1 + test2 + test3) / 3.0;
        }//fin del metodo CalcularPromedioEstudiante

        //Metodo para convertir un promedio numerico a letras
        public string ConvertirPromedioALetras(double promedio)
        {
            string resultado = "";

            switch ((int)promedio / 10)
            {
                case 10:
                case 9:
                    resultado = "A";
                    break;
                case 8:
                    resultado = "B";
                    break;
                case 7:
                    resultado = "C";
                    break;
                default:
                    resultado = "F";
                    break;
            }

            return resultado;
        }//fin del metodo ConvertirPromedioALetras

        //Metodo para mostrar los datos de un estudiante con promedio numerico
        public void MostrarNombreYPromedioNumerico()
        {
            //limpiar la lista
            lstResults.Items.Clear();

            //variable para sumar todos los promedios que haya en la lista
            double total = 0;

            //recorrer el arreglo de estudiantes e ir mostrando sus nombres
            //y promedios en el listbox
            for (int i = 0; i < contadorEstudiantes; i++)
            {
                //mostramos el nombre y el promedio
                lstResults.Items.Add(estudiantes[i, nombre] + "\t" + estudiantes[i, promedio]);
                //acumular el promedio
                total += Convert.ToDouble(estudiantes[i, promedio]);
            }
            //calcular el promedio de la clase
            lblClassAverage.Text = (total / contadorEstudiantes).ToString("F2");

        }//fin del metodo MostrarNombreYpromedioNumerico

        //metodo para mostrar el nombre y el promedio como letras
        public void MostrarNombreYPromedioLetras()
        {
            //limpiar la lista
            lstResults.Items.Clear();

            //variable para sumar todos los promedios que haya en la lista
            double total = 0;

            //recorrer el arreglo de estudiantes e ir mostrando sus nombres
            //y promedios en el listbox
            for (int i = 0; i < contadorEstudiantes; i++)
            {
                //mostramos el nombre y el promedio
                lstResults.Items.Add(estudiantes[i, nombre] + "\t" + ConvertirPromedioALetras(Convert.ToDouble(estudiantes[i, promedio])));
                //acumular el promedio
                total += Convert.ToDouble(estudiantes[i, promedio]);
            }
            //calcular el promedio de la clase
            lblClassAverage.Text = ConvertirPromedioALetras(total / contadorEstudiantes);
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            try
            {
                //obtener los valores de las cajas de texto
                double test1 = Convert.ToDouble(txtTest1.Text.Trim());
                double test2 = Convert.ToDouble(txtTest2.Text.Trim());
                double test3 = Convert.ToDouble(txtTest3.Text.Trim());

                //añadimos el estudiante al arreglo
                estudiantes[contadorEstudiantes, nombre] = txtStudentName.Text;
                estudiantes[contadorEstudiantes, promedio] = CalcularPromedioEstudiante(test1, test2, test3).ToString("F2");
                //incrementamos el contadorEstudiantes para la siguiente entrada
                contadorEstudiantes++;

                //debemos determinar si lo mostramos como numero o como letra
                if (rbnNumeric.Checked)
                {
                    MostrarNombreYPromedioNumerico();
                }
                else
                {
                    MostrarNombreYPromedioLetras();
                }

                //limpiamos las cajas de texto
                txtStudentName.Clear();
                txtTest1.Clear();
                txtTest2.Clear();
                txtTest3.Clear();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void rbnLetter_CheckedChanged(object sender, EventArgs e)
        {
            MostrarNombreYPromedioLetras();
        }

        private void rbnNumeric_CheckedChanged(object sender, EventArgs e)
        {
            MostrarNombreYPromedioNumerico();
        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
