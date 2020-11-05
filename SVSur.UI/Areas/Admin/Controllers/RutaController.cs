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
    public class RutaController : Controller
    {

        // GET: Admin/Producto
        public ActionResult Index(bool estado = true)
        {
            ViewBag.estado = estado;
            var data = new RutaManager().GetAllDTO(estado);
            return View(data);
        }


        [HttpGet]
        public ActionResult Insertar()
        {
            ViewBag.op = CRUD.Insertar.ToString();
            //llenar el combo de la categoria del producto y marca,pero antes formatearlo con el selectlist
            ViewBag.chofer = new SelectList(new ChoferManager().GetAllSimple(), "ChoferID", "Nombre");
            return View("Formulario", new Ruta());

        }


        [HttpPost]
        public ActionResult Insertar(Ruta obj)
        {

            if (ModelState.IsValid)
            {
                int rpta = new RutaManager().Insert(obj);
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
            ViewBag.chofer = new SelectList(new ChoferManager().GetAllSimple(), "ChoferID", "Nombre");
            return View("Formulario", new  RutaManager().Get(id));
        }

        [HttpPost]
        public ActionResult Modificar(Ruta obj)
        {
            // obj.Fecha = DateTime.Now.Date;
            if (ModelState.IsValid)
            {
                int rpta = new RutaManager().Update(obj);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.op = CRUD.Modificar.ToString();
                ViewBag.chofer = new SelectList(new ChoferManager().GetAllSimple(), "ChoferID", "Nombre");

                return View("Formulario", obj);
            }
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            int rpta = new RutaManager().Delete(id);
            return RedirectToAction("index");
        }



        public ActionResult Ver(bool estado = true)
        {
            ViewBag.estado = estado;
            var data = new RutaManager().GetAllDTO(estado);
            return View(data);


        }


    }
}