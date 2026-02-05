//Tarea práctica 2
int? input = null;

Console.WriteLine("Saludos, bienvenido a la calculadora de números de lista. Seleccione una opción");
Console.WriteLine("1. Añadir números en la lista");
Console.WriteLine("2. Ver valores en la lista");
Console.WriteLine("3. Sumar los números de la lista");
Console.WriteLine("4. Restar los números de la lista de manera secuencial");
Console.WriteLine("5. Multiplicar todos los números de la lista");
Console.WriteLine("6. Divide todos los números de la lista de manera secuencial. \n");

try
{
    input = int.Parse(Console.ReadLine());
}
catch (FormatException e)
{
    Console.WriteLine("El valor introducido no es un número. " + e.Message);
}

switch (input)
{
    case 1:
        break;

    case 2:
        break;

    case 3:
        break;

    case 4:
        break;

    case 5:
        break;

    case 6:
        break;


    default:
        Console.WriteLine("Este número no es una opción del menú.");
        break;
}
