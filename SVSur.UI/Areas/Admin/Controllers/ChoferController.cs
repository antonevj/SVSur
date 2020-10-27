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
    public class ChoferController : Controller
    {
        
            // GET: Admin/Producto
            public ActionResult Index(bool estado = true)
            {
                ViewBag.estado = estado;
                var data = new ChoferManager().GetAllDTO(estado);
                return View(data);
            }


            [HttpGet]
            public ActionResult Insertar()
            {
                ViewBag.op = CRUD.Insertar.ToString();
                //llenar el combo de la categoria del producto y marca,pero antes formatearlo con el selectlist
                ViewBag.bus = new SelectList(new BusManager().GetAllSimple(), "BusID", "PlacaBus");
                return View("Formulario", new Chofer());

            }


            [HttpPost]
            public ActionResult Insertar(Chofer obj)
            {
              
                if (ModelState.IsValid)
                {
                    int rpta = new ChoferManager().Insert(obj);
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
            ViewBag.bus = new SelectList(new BusManager().GetAllSimple(), "BusID", "PlacaBus");
            return View("Formulario", new ChoferManager().Get(id));
            }

            [HttpPost]
            public ActionResult Modificar(Chofer obj)
            {
               // obj.Fecha = DateTime.Now.Date;
                if (ModelState.IsValid)
                {
                    int rpta = new ChoferManager().Update(obj);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.op = CRUD.Modificar.ToString();
                ViewBag.bus = new SelectList(new BusManager().GetAllSimple(), "BusID", "PlacaBus");

                return View("Formulario", obj);
                }
            }

            [HttpGet]
            public ActionResult Eliminar(int id)
            {
                int rpta = new ChoferManager().Delete(id);
                return RedirectToAction("index");
            }
        }
    
}