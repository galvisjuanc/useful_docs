namespace POO1
{
    internal class POO1
    {
        static void Main(string[] args)
        {
            SuperHeroe superHeroe = new SuperHeroe();

            var poderVolar = new SuperPoder();
            poderVolar.Nombre = "Volar";
            poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
            poderVolar.Nivel = NivelPoder.NivelDos;

            var superFuerza = new SuperPoder();
            superFuerza.Nombre = "Super Fuerza";
            superFuerza.Descripcion = "Habilidad para romper paredes facil";
            superFuerza.Nivel = NivelPoder.NivelTres;
        }    
    }
}