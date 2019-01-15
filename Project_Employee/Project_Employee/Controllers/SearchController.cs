using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Employee.Controllers
{
    public class SearchController : Controller
    {
        BusinessLogic.Bridge bridge = new BusinessLogic.Bridge();

        [HttpGet]
        [Authorize(Roles = "editor")]
        public ActionResult Index()
        {
            Common.Employee worker = new Common.Employee();

            return View(worker);
        }

        [HttpPost]
        [Authorize(Roles = "editor")]
        public ActionResult Index(Common.Employee worker, string name, string value)
        {
            if(value == "" || value == null || name == null || name == "")
            {
                return RedirectToAction("Index", worker);
            }

            if(name == "name")
            {
              worker.Name = value;
              return  RedirectToAction("NameSearch", worker);
            }

            if (name == "midname")
            {
                worker.MidName = value;
                return RedirectToAction("MidNameSearch", worker);
            }

            if (name == "lastname")
            {
                worker.LastName = value;
                return RedirectToAction("LastNameSearch", worker);
            }

            if (name == "status")
            {
                worker.Status = value;
                return RedirectToAction("StatusSearch", worker);
            }

            if (name == "department")
            {
                worker.Department = value;
                return RedirectToAction("DepartmentSearch", worker);
            }

            return RedirectToAction("Index", worker);
        }

        [Authorize(Roles = "editor")]
        public ActionResult NameSearch(Common.Employee worker)
        {
            return View(bridge.GetNameSelect(worker.Name));
        }

        [Authorize(Roles = "editor")]
        public ActionResult MidNameSearch(Common.Employee worker)
        {
            return View(bridge.GetMidNameSelect(worker.MidName));
        }

        [Authorize(Roles = "editor")]
        public ActionResult LastNameSearch(Common.Employee worker)
        {
            return View(bridge.GetLastNameSelect(worker.LastName));
        }

        [Authorize(Roles = "editor")]
        public ActionResult StatusSearch(Common.Employee worker)
        {
            return View(bridge.GetStatusSelect(worker.Status));
        }

        [Authorize(Roles = "editor")]
        public ActionResult DepartmentSearch(Common.Employee worker)
        {
            return View(bridge.GetDepartmentSelect(worker.Department));
        }
    }
}