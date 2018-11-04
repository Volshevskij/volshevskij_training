using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hw_16.Controllers
{
    public class CatController : Controller
    {
        // GET: Cat
        [HttpGet]
        public ActionResult Index()
        {
            Object obj = new Object();
            return View(obj);
        }

        [HttpPost]
        public ActionResult GetNextPage(Object obj)
        {
            return View("Index2");
        }


    }
}