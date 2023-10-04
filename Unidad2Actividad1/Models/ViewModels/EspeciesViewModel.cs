using Unidad2Actividad1.Models.Entities;

namespace Unidad2Actividad1.Models.ViewModels
{
    public class EspeciesViewModel
    {
        public int Id { get; set; }

        public string Especie { get; set; } = null!;

        public string Clase { get; set; } = null!;

        public string? Habitat { get; set; }

        public double? Peso { get; set; }

        public int? Tamaño { get; set; }

        public string? Observaciones { get; set; }

        public virtual Clase? IdClaseNavigation { get; set; }
    }
}
