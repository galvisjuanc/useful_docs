namespace POODOTNET.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionDeAntiHeroe(string accion)
        {
            return $"El AntiHeroe está realizando la accion: {accion}";
        }
    }
}