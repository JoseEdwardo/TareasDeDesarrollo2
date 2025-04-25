using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Microondas
{
    public partial class Microondas : Form
    {
        public Microondas()
        {
            InitializeComponent();
        }

        //declara una variable tipo string patara almacenar lo que el usuario digita como un tiempo
        string tiempo = "";
        Timer objTiempo;

        private void DisplayTime() 
        {
            //aqui tomamos lo que tiene la variable 
            //tiempo y lo convertimos a un foirmato de hh:MM:SS
            int horas, minutos, segundos;
            //nos vamos a asegurara que la variable tiempo tiega 5 caracteres
            if (tiempo.Length > 5) 
            {
                tiempo = tiempo.Substring(0, 5);
            }
            //Si el usuario digita menos de 5 caracteres, entonces

            string display;
            display = tiempo.PadLeft(5, '0');

            //Ahora descomponemos las horas, minutos y segundos
            horas = int.Parse(display.Substring(0, 1));
            minutos = int.Parse(display.Substring(1, 2));
            segundos = int.Parse(display.Substring(3, 2));

            if (minutos > 59)
            {
                minutos = 59;
            }

            if (segundos > 59)
            {
                segundos = 59;
            }

            tiempo = $"{horas}{minutos}{segundos}";

            //Mostar en la pantalla 
            lblPantalla.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", horas, minutos, segundos);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("C:\\Users\\Jose Edwardo\\Desktop\\C#\\Microondas\\media\\ButonBeep.wav");
            //Vamos concatenando lo digitado
            tiempo = tiempo + btn1.Text;
            //Mostar pantalla
            DisplayTime();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn2.Text;
            //Mostar pantalla
            DisplayTime();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn3.Text;
            //Mostar pantalla
            DisplayTime();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn4.Text;
            DisplayTime();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn5.Text;
            DisplayTime();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn6.Text;
            DisplayTime();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn7.Text;
            DisplayTime();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn8.Text;
            DisplayTime();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn9.Text;
            DisplayTime();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tiempo = tiempo + btn0.Text;
            //Mostar pantalla
            DisplayTime();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Descomponer nuestro tiempo en horas, minutos y segundos
            int horas, minutos, segundos;

            tiempo = tiempo.PadLeft(5, '0');

            horas = int.Parse(tiempo.Substring(0, 1));
            minutos = int.Parse(tiempo.Substring(1, 2));
            segundos = int.Parse(tiempo.Substring(3, 2));

            //Crear un objeto Tiempo
            objTiempo = new Timer(horas, minutos, segundos);

            //Mostramos el objeto en la pantalla
            lblPantalla.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", objTiempo.Horas, objTiempo.Minutos, objTiempo.Segundos);

            //Iniciamos el contador 
            timer1.Enabled = true;

            //Simular que la pantalla este encendida
            pnlPrincipal.BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Decrementamos las propiedades del objeto objTiempo
            if (objTiempo.Segundos > 0)
            {
                objTiempo.Segundos--;
            }
            else if (objTiempo.Minutos > 0)
            {
                objTiempo.Minutos--;
                objTiempo.Segundos = 59;
            }
            else if (objTiempo.Horas > 0)
            {
                objTiempo.Horas--;
                objTiempo.Minutos = 59;
                objTiempo.Segundos = 59;
            }
            else
            {
                //Horas = minutos = Segundos = 0
                timer1.Enabled = false;
                tiempo = "";
                pnlPrincipal.BackColor = SystemColors.Control;
            }

            if (objTiempo.Horas == 0 && objTiempo.Minutos == 0 && objTiempo.Segundos == 0)
            {
                lblPantalla.Text = "Fin";
            }
            else
            {
                //Mostramos el objeto en la pantalla
                lblPantalla.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", objTiempo.Horas, objTiempo.Minutos, objTiempo.Segundos);
            }

        }
        private bool estaPausado = false;
        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) //Si el temporizador esta corriendo 
            {
                timer1.Enabled = false; //Pausar
                estaPausado |= true;

            }
            else if (estaPausado) //Si ya esta pausado se reinicia  
            {
                objTiempo = new Timer(0,0,0); //Reinicia el tiempo
                lblPantalla.Text = "00:00:00"; //Resetea la pantalla
                tiempo = ""; //Borra la entrada de tiempo
                estaPausado = false;
                pnlPrincipal.BackColor = SystemColors.Control; //Apaga la pantalla
            }

        }
    }
}




