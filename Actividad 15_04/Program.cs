
int año = 0;
int fecha = DateTime.Now.Year;

do
{
    Console.WriteLine("Ingrese su año de nacimiento: ");

    if (!int.TryParse(Console.ReadLine(), out año) || año < 1900 || año > fecha)
    {
        Console.WriteLine("Ingrese un año valido");
        año = 0;
    }
} while (año == 0);

Console.WriteLine("Ingreso valido: " + año);

Console.ReadKey();