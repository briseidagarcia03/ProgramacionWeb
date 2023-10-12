using Microsoft.AspNetCore.Mvc;
using Unidad2Actividad2.Models.ViewModels;
using Unidad2Actividad2.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Unidad2Actividad2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PerrosContext context = new();
            IndexViewModel vm = new();
            var datos = context.Razas.OrderBy(x => x.Nombre);
            vm.ListaPerros = datos.Select(x => new PerrosModel
            {
                Id = x.Id,
                Nombre = x.Nombre,
            });
            return View(vm);
        }

        [Route("/Raza/{nombre}")]
        public IActionResult Detalles(string nombre)
        {
            nombre = nombre.Replace("-", " ");
            PerrosContext context = new();
            var datos = context.Razas.Where(x => x.Nombre == nombre)
                .Include(x => x.IdPaisNavigation).Include(x => x.Estadisticasraza)
                .Include(x => x.Caracteristicasfisicas).FirstOrDefault();
            if (datos == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                DetallesViewModel vm = new()
                {
                    Id = (int)datos.Id,
                    Nombre = datos.Nombre,
                    Descripcion = datos.Descripcion,
                    OtrosNombres = datos.OtrosNombres ??"No tiene",
                    PaisOrigen = datos.IdPaisNavigation.Nombre??"Desconocido",
                    PesoMin = datos.PesoMin,
                    PesoMax = datos.PesoMax,
                    AlturaMax = datos.AlturaMax,
                    AlturaMin = datos.AlturaMin,
                    EsperanzaVida = (int)datos.EsperanzaVida,
                    Patas = datos.Caracteristicasfisicas.Patas??"Sin datos",
                    Cola = datos.Caracteristicasfisicas.Cola ?? "Sin datos",
                    Hocico = datos.Caracteristicasfisicas.Hocico ?? "Sin datos",
                    Pelo = datos.Caracteristicasfisicas.Pelo ?? "Sin datos",
                    Color = datos.Caracteristicasfisicas.Color ?? "Sin datos",
                    NivelEnergia = (int)datos.Estadisticasraza.NivelEnergia,
                    FacilidadEntrenamiento = (int)datos.Estadisticasraza.FacilidadEntrenamiento,
                    EjercicioObligatorio = (int)datos.Estadisticasraza.EjercicioObligatorio,
                    AmistadDesconocidos = (int)datos.Estadisticasraza.AmistadDesconocidos,
                    AmistadPerros = (int)datos.Estadisticasraza.AmistadPerros,
                    NecesidadCepillado = (int)datos.Estadisticasraza.NecesidadCepillado,
                    Perros = context.Razas.Where(x => x.Nombre != nombre)
                    .Select(x => new PerrosModel
                    {
                        Id = x.Id,
                        Nombre = x.Nombre
                    })
                    .OrderBy(z => EF.Functions.Random()).Take(4).ToList()//para generar perros random
                };
                return View(vm);
            }

        
        }
    }
}
