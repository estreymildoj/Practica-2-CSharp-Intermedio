//Tarea práctica 2
using Practica2;

int? input = null;



void inicio()
{
    Console.WriteLine("Saludos, bienvenido a la calculadora de números de lista.");
    Console.WriteLine("¿De qué tipo de dato le gustaría que fuera la lista? (Solo se permiten datos númericos)");

    Console.WriteLine("1. int");
    Console.WriteLine("2. float");
    Console.WriteLine("3. double");
    Console.WriteLine("4. decimal");

    introducirNumero();
}


ListaNumeros<int> lista = new ListaNumeros<int>();

inicio();
menu();

//if (input == 1) {
//    ListaNumeros<int> lista = new ListaNumeros<int>();
//}
//else if(input == 2) {
//    ListaNumeros<float> lista = new ListaNumeros<float>();
//}
//else if (input == 3)
//{
//    ListaNumeros<double> lista = new ListaNumeros<double>();
//}
//else if (input == 4)
//{
//    ListaNumeros<decimal> lista = new ListaNumeros<decimal>();
//}
//else
//{
//    Console.WriteLine("Este número no es parte de las opciones.");
//    inicio();
//}



void menu()
{
    Console.WriteLine("Seleccione una opción");
    Console.WriteLine("1. Añadir números en la lista");
    Console.WriteLine("2. Ver valores en la lista");
    Console.WriteLine("3. Sumar los números de la lista");
    Console.WriteLine("4. Restar los números de la lista de manera secuencial");
    Console.WriteLine("5. Multiplicar todos los números de la lista");
    Console.WriteLine("6. Divide todos los números de la lista de manera secuencial. \n");

    introducirNumero();

    switch (input)
    {
        case 1:
            addNumero();
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
}

void introducirNumero()
{
    try
    {
        input = int.Parse(Console.ReadLine());
    }
    catch (FormatException e)
    {
        Console.WriteLine("El valor introducido no es un número. " + e.Message);
    }
}

void addNumero()
{
    Console.WriteLine("Introduce el número que deseas añadir: ");

    string valorDeseado = Console.ReadLine();

    lista.AgregarNumero(valorDeseado);

    menu();
}