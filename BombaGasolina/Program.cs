namespace BombaGasolina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables para almacenar el precio del galon de combustible
            //y la cantidad de gasolina en el tanque

            double precio = 2.00;
            double cantEnELTanque = 300.00;
            
            //imprimir el mensaje inicial
            Console.WriteLine($"El Tanque de Gasolina tiene {cantEnELTanque} galones");
            Console.WriteLine($"El Precio por galón de gasolina es de {precio:C}");
            Console.WriteLine();

            double solicitud;
            double cantDespachada;
            double valorTransaccion;
            
            while(true)
            {
                Console.Write("Introduzca la cantidad de galones que desea solicitar: ");
                solicitud = Convert.ToDouble(Console.ReadLine());

                //determinar si hay suficiente combustible
                if (cantEnELTanque >= solicitud)
                {
                    cantDespachada = solicitud;
                    cantEnELTanque = cantEnELTanque - cantDespachada;
                    valorTransaccion = precio * cantDespachada;
                }
                else
                {
                    cantDespachada = cantEnELTanque;
                    cantEnELTanque = cantEnELTanque - cantDespachada;
                    valorTransaccion = precio * cantDespachada;
                }

                Console.WriteLine($"{solicitud:F2} galones fueron solicitados");
                Console.WriteLine($"{cantDespachada:F2} galones fueron surtidos");
                Console.WriteLine($"{cantEnELTanque:F2} quedan en el tanque");
                Console.WriteLine($"El precio total es {valorTransaccion:C}");
                Console.WriteLine();
            }

        }
    }
}