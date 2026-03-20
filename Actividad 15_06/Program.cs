DateTime fecha;

do
{
    Console.WriteLine("Ingrese una fecha: ");

    if (!DateTime.TryParse(Console.ReadLine(), out fecha))
    {
        Console.WriteLine("Fecha invalida");
        fecha = DateTime.Now;
    }
}while (fecha == DateTime.MinValue);

Console.WriteLine("La fecha ingresada es: " + fecha.ToShortDateString());

Console.ReadKey();