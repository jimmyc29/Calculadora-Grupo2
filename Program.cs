using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());
        // TODO: Implementar la lógica de menú
       switch (opcion){
        case 1: 
        Console.WriteLine("seleccionastes Opcion Sumar");
        Console.WriteLine("ingrese el primer numero");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ingrese el segundo numero");
        int num2= Convert.ToInt32(Console.ReadLine());

        int resultado = Suma (num1 + num2);
        Console.WriteLine("resultado: " + resultado);
        break;

     default:
        Console.WriteLine("Opción no implementada aún.");
        break;
       }
    }

    // TODO: Implementar funciones de suma, resta, multiplicación, división
    static int Suma(int a, int b){
         return a+b;
    }
}