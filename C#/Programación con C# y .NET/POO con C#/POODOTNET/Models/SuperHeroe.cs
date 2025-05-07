namespace POO1WITHDOTNET.Models
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
    }
}
