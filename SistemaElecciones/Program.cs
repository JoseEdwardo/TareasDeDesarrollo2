namespace SistemaElecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Datos de votos por distrito (filas: distritos, columnas: candidatos A-D)
            int[,] votos = {
            { 194,  48, 206,  45 },
            { 180,  20, 320,  16 },
            { 221,  90, 140,  20 },
            { 432,  50, 821,  14 },
            { 820,  61, 946,  18 }
        };

            string[] candidatos = { "A", "B", "C", "D" };
            int numCandidatos = candidatos.Length;
            int[] totales = new int[numCandidatos];

            // a) Imprimir tabla con cabeceras
            Console.WriteLine("Distrito\tA\tB\tC\tD");
            for (int i = 0; i < votos.GetLength(0); i++)
            {
                Console.Write($"{i + 1}\t\t");
                for (int j = 0; j < votos.GetLength(1); j++)
                {
                    Console.Write($"{votos[i, j]}\t");
                    totales[j] += votos[i, j];
                }
                Console.WriteLine();
            }

            // b) Calcular totales y porcentajes
            int totalVotos = totales.Sum();
            Console.WriteLine("\nTotal de votos por candidato:");
            for (int i = 0; i < numCandidatos; i++)
            {
                double porcentaje = (double)totales[i] / totalVotos * 100;
                Console.WriteLine($"Candidato {candidatos[i]}: {totales[i]} votos ({porcentaje:F2}%)");
            }

            // Determinar el más votado
            int indiceMasVotado = Array.IndexOf(totales, totales.Max());
            Console.WriteLine($"\nCandidato más votado: {candidatos[indiceMasVotado]}");

            // c) Verificar si alguien ganó con más del 50%
            if ((double)totales[indiceMasVotado] / totalVotos > 0.5)
            {
                Console.WriteLine($"\n¡El candidato {candidatos[indiceMasVotado]} ha ganado con más del 50% de los votos!");
            }
            else
            {
                // d) Mostrar los dos más votados
                var candidatosOrdenados = totales
                    .Select((v, i) => new { Indice = i, Votos = v })
                    .OrderByDescending(x => x.Votos)
                    .ToArray();

                Console.WriteLine("\nNingún candidato obtuvo más del 50% de los votos.");
                Console.WriteLine($"Los dos candidatos que pasan a la segunda ronda son: {candidatos[candidatosOrdenados[0].Indice]} y {candidatos[candidatosOrdenados[1].Indice]}");
            }
        }
    }
}
