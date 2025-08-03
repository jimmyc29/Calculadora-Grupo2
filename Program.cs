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
        
        Console.WriteLine("ingrese el primer numero");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("ingrese el segundo numero");
        double num2= Convert.ToDouble(Console.ReadLine());

        double resultado;

       switch (opcion){
        case 1: 
      
            resultado = Suma(num1, num2);
             Console.WriteLine("resultado: " + resultado);
             break;

            default:
        Console.WriteLine("Opción no implementada aún.");
        break;
       }
          Console.WriteLine("Presione ENTER para salir...");
        Console.ReadLine();
    }

    // TODO: Implementar funciones de suma, resta, multiplicación, división
    static double Suma(double a, double b){
         return a + b;
    }
}