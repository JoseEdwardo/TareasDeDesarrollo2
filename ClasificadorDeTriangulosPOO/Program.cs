using System;

namespace ClasificadorDeTriangulosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Mensaje para solicitar los datos del triangulo 
            Console.Write("Ingrese el primer lado: ");
            double l1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo lado: ");
            double l2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer lado: ");
            double l3 = Convert.ToDouble(Console.ReadLine());


            //Crear el objeto de la clase triangulo 
            Triangulo miTriangulo = new Triangulo(l1, l2, l3);

            //Mostar los lados 
            miTriangulo.MostrarLados();

            //Verificar si es un triangulo valido 
            if (miTriangulo.EsTrianguloValido())
            {

                Console.WriteLine($"El triángulo es: {miTriangulo.TipoTriangulo()}");

            }
            else 
            {

                Console.WriteLine("Los lados ingresados no forman un triángulo.");

            }
            Console.ReadKey();
        }
    }
}
