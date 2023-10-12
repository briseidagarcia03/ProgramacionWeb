namespace Unidad2Actividad2.Models.ViewModels
{
    public class DetallesViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string OtrosNombres { get; set; } = null!;
        public string PaisOrigen { get; set; } = null!;
        public float PesoMin { get; set; }
        public float PesoMax { get; set; }
        public float AlturaMin { get; set; }
        public float AlturaMax { get; set; }
        public int EsperanzaVida { get; set; }
        public string Patas { get; set; } = null!;
        public string Cola { get; set; } = null!;
        public string Hocico { get; set; } = null!;
        public string Pelo { get; set; } = null!;
        public string Color { get; set; } = null!;
        public int NivelEnergia { get; set; }
        public int FacilidadEntrenamiento { get; set; }
        public int EjercicioObligatorio { get; set; }
        public int AmistadDesconocidos { get; set; }
        public int AmistadPerros { get; set; }
        public int NecesidadCepillado { get; set; }
        public IEnumerable<PerrosModel> Perros { get; set; } = null!;

    }
}
