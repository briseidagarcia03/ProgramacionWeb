using Unidad2Actividad2.Models.Entities;

namespace Unidad2Actividad2.Models.ViewModels
{
    public class PaisesViewModel
    {
        public IEnumerable<PaisesModel> Paises { get; set; } = null!;
    }

    public class PaisesModel
    {
        public string Nombre { get; set; } = null!;
        public IEnumerable<PerrosModel> Perros { get; set; } = null!;
    }
}
