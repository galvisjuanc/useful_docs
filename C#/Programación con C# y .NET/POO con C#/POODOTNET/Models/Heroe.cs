namespace POODOTNET.Models
{
    internal abstract class Heroe
    {
        public abstract string Nombre { get; set; }
        
        public abstract string salvarElMundo();

        public virtual string SalvarLaTierra()
        {
            return $"El Heroe {Nombre} ha salvado la tierra.";
        }
    }
}