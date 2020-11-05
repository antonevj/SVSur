﻿using SVSur.Manager;
using SVSur.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SVSur.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.origen = new SelectList(new RutaManager().GetAllSimple(), "RutaID", "CiudadOrigen");
            ViewBag.destino = new SelectList(new RutaManager().GetAllSimple(), "RutaID", "CiudadDestino");
            return View("Index", new Ruta());

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}