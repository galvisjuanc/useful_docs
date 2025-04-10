namespace Example_3
{
    internal class Basics3
    {
        static void Main(string[] args)
        {
            var ladoA = 0.1;
            var ladoB = 0.1;
            var area = 0.1;

            Console.WriteLine("Calcule el área de un rectángulo ingresando los valores de los lados. Puede manejar decimales si quiere...");
            Console.WriteLine("Digite el valor del lado 1: ");
            ladoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite el valor del lado 2: ");
            ladoB = Convert.ToDouble(Console.ReadLine());

            area = ladoA * ladoB;

            Console.WriteLine("El área del rectangulo es: " + area);
            Console.ReadLine();
        }
    }
}
