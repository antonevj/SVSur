using SVSur.Manager;
using SVSur.Models.Domain;
using SVSur.UI.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SVSur.UI.Areas.Admin.Controllers
{
    public class BusController : Controller
    {
        // GET: Admin/Bus
        public ActionResult Index()
        {
            var data = new BusManager().GetAll(true);
            return View(data);
        }
        [HttpGet]
        public ActionResult Insertar()
        {
            ViewBag.op = CRUD.Insertar.ToString();
            return View("Formulario", new Bus());

        }
        [HttpPost]
        public ActionResult Insertar(Bus obj)
        {
            obj.AñoFabricacion = DateTime.Now.Date;
            if (ModelState.IsValid)
            {
                int rpta = new BusManager().Insert(obj);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Formulario", obj);
            }

        }
        [HttpGet]
        public ActionResult Modificar(int id)
        {
            ViewBag.op = CRUD.Modificar.ToString();
            return View("Formulario", new BusManager().Get(id));

        }
        [HttpPost]
        public ActionResult Modificar(Bus obj)
        {
            if (ModelState.IsValid)
            {
                int rpta = new BusManager().Update(obj);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Formulario", obj);
            }
        }
        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            int rpta = new BusManager().Delete(id);
            return RedirectToAction("Index");
        }

    }
}