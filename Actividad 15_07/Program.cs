
double salario = -1;

do
{
    Console.WriteLine("Ingrese el salario: ");

    if (!double.TryParse(Console.ReadLine(), out salario) || salario < 0)
    {
        Console.WriteLine("Ingrese un salario valido");
        salario = -1;
    }
}while (salario <  0);

Console.WriteLine("El salario ingresado es: " + salario);

Console.ReadKey();
