using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hw_16.Controllers
{
    public class AnimalsController : Controller
    {
        // GET: Animals
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetNextPage(Object obj)
        {
            return View("Index2");
        }
    }
}