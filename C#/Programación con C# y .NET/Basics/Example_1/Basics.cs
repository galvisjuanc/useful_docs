namespace Example_1
{
    internal class Basics 
    {
        static void Main(string[] args)
        {
            int ladoA;
            int ladoB;
            int resultado;

            Console.WriteLine("Calcule el área de un rectángulo ingresando los valores de los lados");
            Console.WriteLine("Digite el valor del lado 1: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el valor del lado 2: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            resultado = ladoA * ladoB;

            Console.WriteLine("El área del rectangulo es: " + resultado);
            Console.ReadLine();
        }
    }
}