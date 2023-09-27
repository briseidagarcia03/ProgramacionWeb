using Microsoft.AspNetCore.Mvc;
using Unidad1Actividad1.Models;

namespace Unidad1Actividad1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            PerfilViewModel perfil = new();
            perfil.Nombre = "Briseida Garcia Espinoza";
            perfil.Carrera = "Sistemas Computacionales";
            perfil.Materia = "Programación Web";
            perfil.Semestre = 7;
            perfil.Correo = "201G0253@rcarbonifera.tecnm.mx";
            perfil.Instituto = "ITESRC";
            perfil.Periodo = "AGO-DIC";
            perfil.NumControl = "201G0253";
            return View(perfil);
        }

    }
}
