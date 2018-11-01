using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.Models;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        [HttpGet]
        public ActionResult Index()
        {
            Models.Calc calc = new Models.Calc();
            calc.RandCalc();
            calc.GetResult();
            return View(calc);
        }

        [HttpPost]
        public ActionResult Index(Models.Calc calc)
        {
            calc.GetResult();
            if(calc.Answer == calc.Result)
            {
                calc.Ret = "Correct";
            }
            else
            {
                calc.Ret = "Uncorrect";
            }
            calc.RandCalc();
            return View(calc);
        }
    }
}