using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC05.Controllers
{
    public class AutoresController : Controller
    {
        // GET: Autores
        public ActionResult Index()
        {
            return View();
        }
    }
}