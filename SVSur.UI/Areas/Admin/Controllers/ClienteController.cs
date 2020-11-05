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
    public class ClienteController : Controller
    {
        // GET: Admin/Cliente
        public ActionResult Index(bool estado = true)
        {
            ViewBag.estado = estado;
            var data = new ClienteManager().GetAll(estado);
            return View(data);
        }
        [HttpGet]
        public ActionResult Insertar()
        {
            ViewBag.op = CRUD.Insertar.ToString();
            return View("Formulario", new Cliente());  
            
        }
        [HttpPost]
        public ActionResult Insertar(Cliente obj)
        {
            if (ModelState.IsValid)
            {
               int rpta= new ClienteManager().Insert(obj);
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
            return View("Formulario", new ClienteManager().Get(id));

        }
        [HttpPost]
        public ActionResult Modificar(Cliente obj)
        {
            if (ModelState.IsValid)
            {
                int rpta = new ClienteManager().Update(obj);
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
            int rpta = new ClienteManager().Delete(id);
            return RedirectToAction("Index");
        }


    }
}