using SVSur.Manager;
using SVSur.Models.Domain;
using SVSur.Models.DTO;
using SVSur.UI.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SVSur.UI.Controllers
{
    public class ReservaController : Controller
    {
        // GET: Reserva
        public ActionResult Index()
        {
            return View();
        }


        private string destino;
        private string origen;
        private string viaje;


        [HttpGet]
        public ActionResult Ver()
        {

            ViewBag.op = "Ver";
           
            ViewBag.origen = new SelectList(new RutaManager().GetAllSimple(), "RutaID", "CiudadOrigen");
            ViewBag.destino = new SelectList(new RutaManager().GetAllSimple(), "RutaID", "CiudadDestino");
            return View("Ver", new Ruta());


        }

        [HttpPost]
        public ActionResult Ver(string CiudadDestino, string CiudadOrigen,string viaje  )
        {

           ViewBag.origen = CiudadOrigen;
            ViewBag.destino = CiudadDestino;
            ViewBag.viaje = viaje;
            var data = new RutaManager().buscar(CiudadDestino,CiudadDestino,viaje);

            return RedirectToAction("Formulario",data);


        }

        [HttpGet]
        public ActionResult viajes()
        {
            ViewBag.origen = origen;
            ViewBag.destino = destino;
            ViewBag.viaje = viaje;

            return View();


        }

        [HttpPost]
        public ActionResult viajes(bool estado)
        {


            var data = new RutaManager().GetAllDTO(estado);
            return View(data);


        }


    }
}