using System;

namespace Example_5
{
    internal class Basics5
    {
        static void Main(string[] args)
        {
            var variable1 = 0.0;
            var variable2 = 0.0;
            var resultado = 0d;
            
            Console.WriteLine("Calculadora de valores");
            Console.WriteLine("Escriba el primer valor");
            variable1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba el segundo valor");
            variable2 = Convert.ToDouble(Console.ReadLine());

            resultado = variable1 + variable2;
            Console.WriteLine("La suma de los dos valores es: " + resultado);

            resultado = variable1 - variable2;
            Console.WriteLine("La resta de los dos valores es: " + resultado);

            resultado = variable1 * variable2;
            Console.WriteLine("La multiplicación de los dos valores es: " + resultado);

            resultado = variable1 / variable2;
            Console.WriteLine("La división de los dos valores es: " + resultado);

            resultado = variable1 % variable2;
            Console.WriteLine("El modulo de los dos valores es: " + resultado);

            variable1++;
            Console.WriteLine("El incremento del valor 1 es: " + variable1);

            variable2--;
            Console.WriteLine("El decremento del valor 2 es: " + variable2);

            ++variable1;
            --variable2;

            Console.WriteLine("El incremento del valor 1 es: " + variable1);
            Console.WriteLine("El decremento del valor 2 es: " + variable2);

            Console.ReadKey();
        }
    }
}
