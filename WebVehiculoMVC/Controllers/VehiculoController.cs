using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVehiculoMVC.Models;

namespace WebVehiculoMVC.Controllers
{
    public class VehiculoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agregar()
        {
            GestorVehiculo GV = new GestorVehiculo();
            VehiculoMarca VM = new VehiculoMarca();
            VM.V = new Vehiculo();
            VM.M = GV.ObtenerMarcas();
            return View(VM);
        }
        [HttpPost]
        public ActionResult Agregar(VehiculoMarca nuevoVehiculo)
        {
            GestorVehiculo GV = new GestorVehiculo();
            GV.Agregar(nuevoVehiculo.V);
            return View("Index");
        }

        public ActionResult Modificar()
        {
            GestorVehiculo GV = new GestorVehiculo();
            VehiculoMarca VM = new VehiculoMarca();
            VM.V = new Vehiculo();
            VM.M = GV.ObtenerMarcas();
            return View(VM);
        }

        [HttpPost]
        public ActionResult Modificar(VehiculoMarca cambiarVehiculo)
        {
            GestorVehiculo GV = new GestorVehiculo();
            GV.Modificar(cambiarVehiculo.V);
            return View("Index");
        }

        public ActionResult Eliminar()
        {
            GestorVehiculo GV = new GestorVehiculo();
            VehiculoMarca VM = new VehiculoMarca();
            VM.V = new Vehiculo();
            VM.M = GV.ObtenerMarcas();
            return View(VM);
        }

        [HttpPost]
        public ActionResult Eliminar(VehiculoMarca borrarVehiculo)
        {
            GestorVehiculo GV = new GestorVehiculo();
            GV.Eliminar(borrarVehiculo.V);
            return View("Index");
        }

        public ActionResult Listar()
        {
            GestorVehiculo GV = new GestorVehiculo();
            List<Vehiculo> lista = GV.Listar();
            return View(lista);
        }
    }
}
