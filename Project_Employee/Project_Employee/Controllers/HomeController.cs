using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Employee.Controllers
{
    public class HomeController : Controller
    {
        BusinessLogic.Bridge bridge = new BusinessLogic.Bridge();
        string defaultName = "Default/default.jpg";

        public ActionResult Index()
        {
            foreach (var file in System.IO.Directory.GetFiles(Server.MapPath("~") + "/Content/Pics"))
            {
                System.IO.File.Delete(file);
            }

            return View(bridge.GetFullEmployee());
        }

        public ActionResult About()
        {
            foreach (var file in System.IO.Directory.GetFiles(Server.MapPath("~") + "/Content/Out"))
            {
                System.IO.File.Delete(file);
            }

            var client = new PhotoService.PhotoServiceClient("BasicHttpBinding_IPhotoService");

            var path = "D:/For some shit/For some shit/Файлы/Pull"; //Path.Combine(Server.MapPath("~/Content/Pull/"));

            var path2 = Path.Combine(Server.MapPath("~/Content/Out/def.jpg"));

            byte[] buffer = client.GetPhoto(path);

            FileStream stream = new FileStream(path2, FileMode.OpenOrCreate);

            try
            {
                stream.Write(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }

            }

            return View();
        }

        [Authorize(Roles = "admin")]
        public ActionResult AdminPage()
        {
            return View();
        }

        [Authorize(Roles = "editor")]
        public ActionResult EditorPage()
        {
            foreach (var file in System.IO.Directory.GetFiles(Server.MapPath("~") + "/Content/Pics"))
            {
                System.IO.File.Delete(file);
            }

            return View(bridge.GetFullEmployee());
        }
     
        [Authorize(Roles = "editor")]
        public ActionResult Delete(string email)
        {
            if (email != null)
            {
                bridge.DeleteEmployee(email);
                return RedirectToAction("EditorPage");
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpGet]
        [Authorize(Roles = "editor")]
        public ActionResult AddEmployee()
        {
            Common.Employee worker = new Common.Employee();
            return View(worker);
        }

        [HttpPost]
        [Authorize(Roles = "editor")]
        public ActionResult AddEmployee(Common.Employee worker, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Temp/"), fileName);
                file.SaveAs(path);

                FileStream fs = new FileStream(path, FileMode.Open);

                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);

                worker.Photo = new byte[buffer.Length];
                worker.Photo = buffer;

                fs.Close();
            }
            else
            {
                worker.Photo = new byte[1];
                worker.Photo[0] = 0;
            }
            
            bridge.AddEmployee(worker);

            foreach (var filepath in System.IO.Directory.GetFiles(Server.MapPath("~") + "/Content/Temp"))
            {
                System.IO.File.Delete(filepath);
            }

            return RedirectToAction("EditorPage");
        }

        [HttpGet]
        [Authorize(Roles = "editor")]
        public ActionResult UpdateEmployee(int id)
        {
            Common.Employee worker = new Common.Employee();
            worker.Id = id;
            return View(worker);
        }

        [HttpPost]
        [Authorize(Roles = "editor")]
        public ActionResult UpdateEmployee(Common.Employee worker, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Temp/"), fileName);
                file.SaveAs(path);

                FileStream fs = new FileStream(path, FileMode.Open);

                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);

                worker.Photo = new byte[buffer.Length];
                worker.Photo = buffer;

                fs.Close();
            }
            else
            {
                worker.Photo = new byte[1];
                worker.Photo[0] = 0;
            }

            bridge.UpdateEmployee(worker);

            foreach (var filepath in System.IO.Directory.GetFiles(Server.MapPath("~") + "/Content/Temp"))
            {
                System.IO.File.Delete(filepath);
            }

            return RedirectToAction("EditorPage");
        }

        [Authorize(Roles = "editor")]
        public ActionResult GetEmployeeDetails(string email)
        {
            var tmp = bridge.GetEmailSelect(email);

            byte[] fileBytes = tmp.Photo;
            string fileName = tmp.Email + ".jpg";

            tmp.PhotoUrl = fileName;

            var path = Path.Combine(Server.MapPath("~/Content/Pics/"), fileName);

            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

            try
            {             
                    stream.Write(fileBytes, 0, fileBytes.Length);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
                    
            }

            if (tmp.Photo.Length == 1)
            {
                tmp.PhotoUrl = defaultName;
            }
            return View(tmp);
        }
    }
}