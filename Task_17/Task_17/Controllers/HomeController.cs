using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_17.Models;

namespace Task_17.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        UserContext users = new UserContext();
        [HttpGet]
        public ActionResult Index()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                var groups = users.Users.ToList();
                users.Users.Add(user);
                users.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Base()
        {
            return View(users.Users.ToList());
        }

        [HttpPost]
        public ActionResult Base(string id, string name)
        {
            int ID = Convert.ToInt32(id);
            if (id != null)
            {
                if (name == "Remove")
                {
                    DeleteUser(ID);
                    return View(users.Users.ToList());
                }
                else
                {
                    return RedirectToAction("ChangeUser", "Home", new { id = id });
                }
            }
            return View(users.Users.ToList());
        }

        public ActionResult DeleteUser(int id)
        {
            User someUser;
            someUser = (users.Users.Where(a => a.Id == id)).SingleOrDefault();
            users.Entry(someUser).State = System.Data.Entity.EntityState.Deleted;
            users.SaveChanges();
            return RedirectToAction("Base", "Home");
        }

        [HttpGet]
        public ActionResult ChangeUser(string id)
        {
            User user = new User();
            int ID = Convert.ToInt32(id);
            user.Id = ID;

            return View(user);
        }

        [HttpPost]
        public ActionResult ChangeUser(User user)
        {
            User someUser = new User();
            someUser = (users.Users.Where(a => a.Id == user.Id)).SingleOrDefault();
            someUser.Name = user.Name;
            someUser.MidName = user.MidName;
            someUser.LastName = user.LastName;
            user = someUser;          
                users.SaveChanges();
                return RedirectToAction("Base", "Home");         
        }
    }
}