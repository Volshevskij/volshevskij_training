using System.Web.Mvc;

namespace Project_Employee.Controllers
{
    public class SearchController : Controller
    {
        BusinessLogic.IBridge bridge;

        public SearchController(BusinessLogic.IBridge _bridge)
        {
            this.bridge = _bridge;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            Common.Employee worker = new Common.Employee();

            return View(worker);
        }

        [HttpPost]
        [AllowAnonymous]
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

            if (name == "workperiod") 
            {
                worker.WorkPeriod = value;
                return RedirectToAction("WorkPeriodSearch", worker);
            }

            return RedirectToAction("Index", worker);
        }

        [AllowAnonymous]
        public ActionResult NameSearch(Common.Employee worker)
        {
            return View(bridge.GetNameSelect(worker.Name));
        }

        [AllowAnonymous]
        public ActionResult MidNameSearch(Common.Employee worker)
        {
            return View(bridge.GetMidNameSelect(worker.MidName));
        }

        [AllowAnonymous]
        public ActionResult LastNameSearch(Common.Employee worker)
        {
            return View(bridge.GetLastNameSelect(worker.LastName));
        }

        [AllowAnonymous]
        public ActionResult StatusSearch(Common.Employee worker)
        {
            return View(bridge.GetStatusSelect(worker.Status));
        }

        [AllowAnonymous]
        public ActionResult DepartmentSearch(Common.Employee worker)
        {
            return View(bridge.GetDepartmentSelect(worker.Department));
        }

        [AllowAnonymous]
        public ActionResult WorkPeriodSearch(Common.Employee worker)
        {
            return View(bridge.GetWorkPeriodSelect(worker.WorkPeriod));
        }
    }
}