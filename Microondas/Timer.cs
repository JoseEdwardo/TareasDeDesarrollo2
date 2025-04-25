using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    public class Timer
    {
        //atributos para el reloj
        private int horas;
        private int minutos;
        private int segundos;

        //propiedades para controlar los accesos
        public int Horas 
        {

            get { return horas;  }
            set 
            {
                if (horas < value) 
                {
                    horas = value;
                }
                else
                {
                    horas = 0;
                }
            }
           
        }
        public int Minutos 
        {

            get { return minutos; }
            set 
            {
                if (value < 60)
                {
                    minutos = value;
                }
                else 
                {
                    minutos = 0;
                }
            }
        
        
        }
        public int Segundos 
        {

            get { return segundos; }
            set
            {
                if (value < 60)
                {
                    segundos = value;
                }
                else
                {
                    segundos = 0;
                }

            }

        }
        //Constructor 
        public Timer (int horas, int minutos, int segundos) 
        {
        
            Horas = horas;
            Minutos = minutos;
            Segundos = segundos;
        
        }
        


    }
}
