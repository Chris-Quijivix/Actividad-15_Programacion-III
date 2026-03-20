
double nota = -1;

do
{
    Console.WriteLine("Ingrese una nota: ");

    if (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
    {
        Console.WriteLine("Ingrese una nota valida");
        nota = -1;
    }
}while (nota < 0);

if (nota >= 61)
{
    Console.WriteLine("Aprobado");
}
else
{
    Console.WriteLine("Reprobado");
}

Console.ReadKey();
