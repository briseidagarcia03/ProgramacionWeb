using Microsoft.AspNetCore.Mvc;
using Unidad1Actividad2.Models;

namespace Unidad1Actividad2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(ConversionViewModel vm)
        {
            if (vm.Moneda == "USD")
            {
                vm.Resultado = vm.Cantidad / 18;
            }
            else if (vm.Moneda == "MXN")
            {
                vm.Resultado = vm.Cantidad * 18;
            }
            return View(vm);
        }


    }
}
