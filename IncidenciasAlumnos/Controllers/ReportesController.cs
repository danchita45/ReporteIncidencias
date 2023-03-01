using IncidenciasAlumnos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace IncidenciasAlumnos.Controllers
{
    public class ReportesController : Controller
    {
        public static List<Reporte> reporte = new List<Reporte>();
        public IActionResult Index()
        {

            return View(reporte);
        }

        public IActionResult Detalle()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateRep(string Account, string Description)
        {
            Reporte rep = new Reporte();
            rep.Descripcion = Description;

            rep.Alumno = new Alumno()
            {
                NumeroCuenta = Convert.ToInt32(Account),
                Nombre = "Daniel F Barrera",
                Riesgo = new Riesgo()
                {
                    RiesgoId = 0
                },
                Incidencias = 0,
            };
        reporte.Add(rep);

        return RedirectToAction("Index", reporte);
    }
}
}
