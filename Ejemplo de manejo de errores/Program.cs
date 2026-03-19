

int edad = 0;

do
{
    Console.WriteLine("Ingrese una edad:");
    if(!int.TryParse(Console.ReadLine(), out edad))
    {
        Console.WriteLine("edad ingresado no valida");
        edad = 0;
    }
    else if(edad <= 0 || edad > 100 )
    {
        Console.WriteLine("edad ingresada supera rango establecido");
        edad = 0;
    }
}
while (edad == 0);

Console.WriteLine("edad: " + edad);

Console.ReadKey();