
int numero;
string ingreso;

do
{
    Console.WriteLine("Ingrese un numero: ");
    ingreso = Console.ReadLine();

    if (!int.TryParse(ingreso, out numero))
    {
        Console.WriteLine("Ingreso de numero no valido");
    }

}while (!int.TryParse(ingreso, out numero));

if (numero % 2  == 0)
{
    Console.WriteLine("El numero ingresado es par: " + numero);
}
else
{
    Console.WriteLine("El numero ingresado es impar: " + numero);
}

Console.ReadKey();