using Microsoft.AspNetCore.Mvc;
using Unidad2Actividad1.Models.Entities;
using Unidad2Actividad1.Models.ViewModels;

namespace Unidad2Actividad1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            AnimalesContext context = new();
            IndexViewModel vm = new();
            var datos = context.Clase.OrderBy(x => x.Nombre);
            vm.Clases = datos.Select(x => new ClaseModel
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Descripcion = x.Descripcion
            });
            return View(vm);
        }
    }
}
