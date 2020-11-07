using SVSur.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SVSur.UI.Areas.Admin.Controllers
{
    public class autobusController : Controller
    {
        // GET: Admin/autobus
      
        public ActionResult Index(bool estado = true)
        {
            ViewBag.estado = estado;
            var data = new RutaManager().GetAllDTO(estado);
            return View(data);
        }

    }
}