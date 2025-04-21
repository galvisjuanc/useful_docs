namespace POO1
{
    interface class SuperPoder 
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public NivelPoder Nivel { get; set; }

        public SuperPoder() {
            Nivel = NivelPoder.NivelUno;
        }
    }

    enum NivelPoder 
    {
        NivelUno,
        NivelDos,
        NivelTres
    }
}