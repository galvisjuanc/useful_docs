namespace POODOTNET.Models
{
    internal class SuperHeroe : Heroe, ISuperHeroe
    {
        public int Id { get; set; }

        public override string Nombre
        {
            get {return _Nombre;}
            set { _Nombre = value.Trim(); }
        }

        public string NombreEIdentidadSecreta 
        {
            get 
            {
                return $"{Nombre} ({IdentidadSecreta})";
            } 
        }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public List<SuperPoder> SuperPoderes { get; set; }
        public bool PuedeVolar { get; set; }
        private string _Nombre;

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }
    }
}
