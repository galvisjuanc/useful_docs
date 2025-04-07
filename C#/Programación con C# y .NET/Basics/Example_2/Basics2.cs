namespace Example_2
{
    internal class Basics2 
    {
        static void Main(string[] args)
        {
            double ladoA;
            double ladoB;
            double resultado;

            Console.WriteLine("Calcule el área de un rectángulo ingresando los valores de los lados. Puede manejar decimales si quiere...");
            Console.WriteLine("Digite el valor del lado 1: ");
            ladoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite el valor del lado 2: ");
            ladoB = Convert.ToDouble(Console.ReadLine());

            resultado = ladoA * ladoB;

            Console.WriteLine("El área del rectangulo es: " + resultado);
            Console.ReadLine();
        }
    }
}