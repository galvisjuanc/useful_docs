namespace Example_11
{
    internal class Basics11
    {
        static void Main(string[] args)
        {
            int numero, final, calculo, contador = 1;
            Console.WriteLine("Tablas de Multiplicar");
            Console.WriteLine("Digite un número para calcular las tablas de multiplicar");
            numero = Convert.ToInt32(Console.ReadLine());
            final = contador * 11;

            Console.WriteLine($"La tabla de multiplicar del {numero} es: ");

            while (contador < final)
            {
                calculo = numero * contador;
                Console.WriteLine(calculo);
                contador++;
            }
        }
    }
}
