namespace POODOTNET.Models
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"ID: {superHeroe.Id}");
            Console.WriteLine($"Nombre: {superHeroe.Nombre}");
            Console.WriteLine($"Identidad Secreta: {superHeroe.IdentidadSecreta}");
        }
    }
}