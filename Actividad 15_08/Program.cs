
double numero;

do
{
    Console.WriteLine("Ingrese un numero: ");

    if (!double.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Numero ingresado no valido");
        numero = -1;
    }
    else if (numero < 0)
    {
        Console.WriteLine("Ingrese numeros positivos unicamente");
    }
} while (numero < 0);

double raiz = numero * 0.5;

Console.WriteLine("La raiz cuadrada del numero ingresado es: " + raiz);

Console.ReadKey();