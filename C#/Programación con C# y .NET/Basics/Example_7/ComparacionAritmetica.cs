namespace Example_7
{
    internal class ComparacionAritmetica
    {
        static void Main(string[] args)
        {
            var (valor1, valor2, valor3) = (10,4,8);
            Console.WriteLine("Los valores son: " + valor1 + ", " + valor2 + ", " + valor3);

            bool resultado1 = valor1 == valor2;
            Console.WriteLine("EL resultado de la comparación valor1 == valor2 es: " + resultado1);

            bool resultado2 = valor1 != valor2;
            Console.WriteLine("EL resultado de la comparación valor1 != valor2 es: " + resultado2);

            bool resultado3 = valor1 < valor2;
            Console.WriteLine("EL resultado de la comparación valor1 < valor2 es: " + resultado3);

            bool resultado4 = valor1 > valor2;
            Console.WriteLine("EL resultado de la comparación valor1 > valor2 es: " + resultado4);

            bool resultado5 = valor2 <= valor3;
            Console.WriteLine("EL resultado de la comparación valor2 <= valor3 es: " + resultado5);

            bool resultado6 = valor2 >= valor3;
            Console.WriteLine("EL resultado de la comparación valor2 >= valor3 es: " + resultado6);
        }
    }
}
