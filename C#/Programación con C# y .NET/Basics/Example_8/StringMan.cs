namespace Example_8
{
    internal class StringMan
    {
        static void Main(string[] args)
        {
            int altura = 180;
            int edad = 32;
            string nombre = "Juan Camilo Galvis Cuéllar";
            string informacion = "Nació en Bogotá, el 2 de Agosto de 1992. Es ingeniero electrónico y desarrollador";
            var hobby = "hapkido";

            string tarjetaDeIdentificacion = $"La informacion de {nombre} es la siguiente: \n " +
                                             $"Su edad es {edad}\n" +
                                             $"su altura es {altura} cm\n" +
                                             $"Informacion relevante: {informacion} \n" +
                                             $"Su hobby es: {hobby}";

            Console.WriteLine(tarjetaDeIdentificacion);
        }
    }
}