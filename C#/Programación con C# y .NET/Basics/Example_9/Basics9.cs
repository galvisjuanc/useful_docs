namespace Example_9
{
    internal class Basics9
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Digite su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
                Console.WriteLine("Usted es mayor de Edad en Colombia");
            else if (edad > 0 && edad < 18)
                Console.WriteLine("Usted es menor de Edad en Colombia");
            else
                Console.WriteLine("Digitó un numero equivocado");
        }
    }
}