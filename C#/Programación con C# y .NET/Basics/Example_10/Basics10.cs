namespace Example_10
{
    internal class Basics10
    {
        static void Main(string[] args)
        {
            char letra = 'e';
            Console.WriteLine("Elige una letra de las siguientes para recibir un mensaje de fin de año: a, b, c, d");
            try {
                letra = Convert.ToChar(Console.ReadLine());
            } catch (Exception ex)  {
                Console.WriteLine(ex.ToString());
            }


            switch (letra)
            {
                case 'a':
                    Console.WriteLine("Eres muy melo");
                    break;
                case 'b':
                    Console.WriteLine("Pasala bien con tu familia");
                    break;
                case 'c':
                    Console.WriteLine("Cuida a los que más quieres");
                    break;
                case 'd':
                    Console.WriteLine("Sigue tus sueños");
                    break;
                default:
                    Console.WriteLine("Letra errada. Fin del programa");
                    break;
            }
        }
    }
}