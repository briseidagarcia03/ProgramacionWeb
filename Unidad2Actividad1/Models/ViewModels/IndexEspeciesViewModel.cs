namespace Unidad2Actividad1.Models.ViewModels
{
    public class IndexEspeciesViewModel
    {
        public IEnumerable<EspeciesModel> Especies { get; set; } = null!;
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
    }

    public class EspeciesModel
    {
        public int Id { get; set; }
        public string Especie { get; set; } = null!;
    }
}
