using Project_Employee.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Project_Employee
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        protected void Application_Start()
        {
            foreach (var file in System.IO.Directory.GetFiles(Server.MapPath("~") + "/Content/Pics"))
            {
                System.IO.File.Delete(file);
            }

            logger.Info("Application Start");

            Database.SetInitializer<ApplicationDbContext>(new AppUserInitializer());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        public override void Init()
        {
            logger.Info("Application Init");
        }

        public override void Dispose()
        {
            logger.Info("Application Dispose");
        }

        protected void Application_Error()
        {
            logger.Info("Application Error");
        }


        protected void Application_End()
        {
            logger.Info("Application End");
        }
    }
}

