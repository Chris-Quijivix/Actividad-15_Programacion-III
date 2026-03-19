
double precio  = 0;

do
{
    Console.WriteLine("Ingrese el precio del producto: ");

    if (!double.TryParse(Console.ReadLine(), out precio) || precio  <= 0)
    {
        Console.WriteLine("Ingreso no valido");
        precio = 0;
    }
}while (precio == 0);

Console.WriteLine("Precio ingresado valido, es: " + precio);

Console.ReadKey();