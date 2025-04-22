namespace POO1
{
    class SuperHeroe
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public List<SuperPoder> SuperPoderes { get; set; }
        public bool PuedeVolar { get; set; }

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        
    }
}