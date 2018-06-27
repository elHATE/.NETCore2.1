using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prode.Core.Entidades;

namespace WebApplication2_MVC.Controllers
{
    public class PartidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            Equipo1 equipo1 = new Equipo1() {
                EquipoID = 1,
                Nombre = "Argentina"
            };

            Equipo1 equipo2 = new Equipo1()
            {
                EquipoID = 2,
                Nombre = "Nigeria"
            };

            Partido partido3 = new Partido()
            {
                EquipoLocal = equipo1,
                EquipoVisitante = equipo2,
                GolesLocal = 2,
                GolesVisitante = 1,
                Fecha = new DateTime(),
            };
            ViewBag.Partido = partido3;
            return View();
        }
    }
}