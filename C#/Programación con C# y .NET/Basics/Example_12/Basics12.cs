namespace Example_12
{
    internal class Basics12
    {
        static void Main(string[] args)
        {
            var (numero, resultado) = (0,0);
            Console.WriteLine("Tabla de Multiplicar usando un for");
            Console.WriteLine("Digite el número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La tabla es: ");
            for (int i = 0; i <= 10; i++)
            {
                resultado = numero * i;
                Console.WriteLine(resultado);
            }
        }
    }
}