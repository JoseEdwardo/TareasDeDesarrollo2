int pisoActual = 1; //Aqui se declaran las variables...
int pisoDestino;

while (true)
{
    Console.WriteLine($"Se encuentra en el piso: {pisoActual}");
    Console.WriteLine("A que piso desea moverse?: ");

    int.TryParse(Console.ReadLine(), out pisoDestino);

    //Validaciones
    if (pisoDestino > 15 || pisoDestino < 1)
    {
        Console.WriteLine("Piso invalido, intente de nuevo");
        continue;
    }

    if (pisoDestino == pisoActual)
    {
        Console.WriteLine("Ya estas en este piso");
        continue;
    }

    // Logica del ascensor
    //Subida
    if (pisoDestino > pisoActual)
    {
        while (pisoActual != pisoDestino)
        {
            pisoActual += 1;
            Console.WriteLine($"subiendo, ahora esta en el piso: {pisoActual}");
        }
    }
    //Bajada
    else
    {
        while (pisoActual != pisoDestino)
        {
            pisoActual -= 1;
            Console.WriteLine($"bajando, ahora esta en el piso: {pisoActual}");
        }
    }
    Console.ReadKey();
    Console.Clear();
}

