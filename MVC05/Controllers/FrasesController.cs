using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC05.Controllers
{
    public class FrasesController : Controller
    {
        // GET: Frases
        public ActionResult Index()
        {
            return View();
        }
    }
}