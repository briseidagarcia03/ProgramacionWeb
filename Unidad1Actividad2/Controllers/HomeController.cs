using Microsoft.AspNetCore.Mvc;
using Unidad1Actividad2.Models;

namespace Unidad1Actividad2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {     
            return View();
        }

        public IActionResult Conversion(ConversionViewModel vm)
        {
            if(vm.MonedaOrigen == vm.MonedaDestino)
            {
                vm.Resultado = vm.Cantidad;
            }
            else if (vm.MonedaOrigen == "MXN" && vm.MonedaDestino == "USD")
            {
                vm.Resultado = vm.Cantidad / 18;
            }
            else if(vm.MonedaOrigen == "USD" && vm.MonedaDestino == "MXN")
            {
                vm.Resultado = vm.Cantidad * 18;
            }
            return View(vm);
        }

    }
}
