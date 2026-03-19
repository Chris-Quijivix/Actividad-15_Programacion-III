
int cantidad = 0;

do
{
    Console.WriteLine("Cuantos estudiantes va a ingresar: ");

    if (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
    {
        Console.WriteLine("Ingreso invalido");
        cantidad = 0;
    }
}while (cantidad == 0);

Console.WriteLine("Ingreso de estudiantes valido, cantidad: " + cantidad);

Console.ReadKey();
