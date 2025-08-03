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

        //Se debe validar la entrada del usuario funcion adicional
        
        double num1 = 0;
        double num2 = 0;

        while (true)
        {
            Console.Write("Ingrese el primer número: ");
            try
            {
                num1 = double.Parse(Console.ReadLine());
                break; // Salir del bucle si es un número
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
            }
        }

        while (true)
        {
            Console.Write("Ingrese el segundo número: ");
            try
            {
                num2 = double.Parse(Console.ReadLine());
                break; // Salir del bucle si es un número
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
            }
        }

        double resultado = 0;

        switch (opcion)
        {
            case 1:

                resultado = Suma(num1, num2);
                Console.WriteLine("El resultado es: " + resultado);
                break;

            case 2:
                resultado = Resta(num1, num2);
                Console.WriteLine("El resultado es: " + resultado);
                break;

            case 3:
                resultado = Multplicar(num1, num2);
                Console.WriteLine("El resultado es: " + resultado);
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
        Console.WriteLine("Presione ENTER para salir...");
        Console.ReadLine();
    }

    // TODO: Implementar funciones de suma, resta, multiplicación, división
    static double Suma(double a, double b)
    {
        return a + b;
    }
    static double Resta(double a, double b)
    {
        return a - b;
    }

    static double Multplicar(double a, double b)
    {
        return a * b;
    }
}