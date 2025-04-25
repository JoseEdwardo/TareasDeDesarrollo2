using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasificadorDeTriangulosPOO
{
    internal class Triangulo
    {
        //Atributos privados (Encapsulamineto)
        private double lado1;
        private double lado2;
        private double lado3;

        //Constructor para inicializar el triangulo 
        public Triangulo(double l1, double l2, double l3) 
        {

            lado1 = l1;
            lado2 = l2;
            lado3 = l3;
        
        }

        //Metodo para mostrar los lados del trinagulo
        public void MostrarLados() 
        {

            Console.WriteLine($"Lados del triangulo: {lado1}, {lado2}, {lado3}");
        
        }

        //Metodo para verificar si los lados forman un trinagulo valido
        public bool EsTrianguloValido() 
        {

            return (lado1 + lado2 > lado3) &&
                   (lado1 + lado3 > lado2) &&
                   (lado2 + lado3 > lado1);
        
        }

        //Metodo para determinar el tipo de triangulo
        public string TipoTriangulo() 
        {

            if (!EsTrianguloValido()) 
            {

                return "Los lados no forman un triangulo valido.";
            
            }

            if (lado1 == lado2 && lado2 == lado3)
            {

                return "Equilatero (Todos los lados son iguales)";

            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {

                return "Isósceles (Dos lados iguales)";

            }
            else 
            {

                return "Escaleno (Todos los lados diferentes)";

            }

        }
        
    }
}
