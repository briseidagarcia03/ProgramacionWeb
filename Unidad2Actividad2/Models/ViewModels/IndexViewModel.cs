namespace Unidad2Actividad2.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<PerrosModel> ListaPerros { get; set; } = null!;
        public IEnumerable<char> LetraAbecedario { get; set; } = null!;
    }

    public class PerrosModel
    {
        public uint Id { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
