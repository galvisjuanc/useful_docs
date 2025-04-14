namespace Example_6
{
    internal class Comparacion
    {
        static void Main(string[] args)
        {
            var (valor1, valor2, valor3) = (true, false, false);

            bool resultAnd = valor1 && valor2 && valor3;
            Console.WriteLine(resultAnd);

            bool resultOr = valor1 || valor2 || valor3;
            Console.WriteLine(resultOr);

            bool resultAndOr = (valor1 && valor2) || valor3;
            Console.WriteLine(resultAndOr);

            bool resultNot = !valor1;
            Console.WriteLine(resultNot);

            bool resultXor = valor1 ^ valor2 ^ valor3;
            Console.WriteLine(resultXor);
        }
    }
}
