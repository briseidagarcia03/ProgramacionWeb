using Microsoft.AspNetCore.Mvc;
using Unidad2Actividad1.Models.Entities;
using Unidad2Actividad1.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace Unidad2Actividad1.Controllers
{
    public class EspeciesController : Controller
    {
        public IActionResult Index(string id)
        {
            AnimalesContext context = new();
            var especies = context.Clase.Include(x=> x.Especies).FirstOrDefault(x => x.Nombre == id);
            var datos = new IndexEspeciesViewModel
            {
                Id = especies.Id,
                Nombre = id ?? "No tiene nombre",
                Especies = especies.Especies.Select(e => new EspeciesModel
                {
                    Id = e.Id,
                    Especie = e.Especie ?? "No tiene nombre"
                })
            };
            return View(datos);       
        }

     
        public IActionResult Especie(string Id)
        {
            AnimalesContext context = new();
            var datos = context.Especies.Include(x => x.IdClaseNavigation).FirstOrDefault(x => x.Especie == Id);
            if (datos == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                EspeciesViewModel vm = new()
                {
                    Id = datos.Id,
                    Especie = datos.Especie,
                    Clase = datos.IdClaseNavigation.Nombre,
                    Peso = datos.Peso,
                    Tamaño = datos.Tamaño,
                    Habitat = datos.Habitat ?? "No hay datos",
                    Observaciones = datos.Observaciones ?? "No hay datos"
                };
                return View(vm);
            }
            
        }
    }
}
