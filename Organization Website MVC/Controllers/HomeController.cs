using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Organization_Website_MVC.Controllers
{
    public class HomeController : Controller
    {
        WebsiteDBEntities WebsiteDB;

        System.Collections.ArrayList allData;

        public HomeController()
        {
            WebsiteDB = new WebsiteDBEntities();

            allData = new System.Collections.ArrayList();

            allData.Add(WebsiteDB.organizations.ToList());
            allData.Add(WebsiteDB.people.ToList());
            allData.Add(WebsiteDB.connections.ToList());
        }

        public ActionResult Index()
        {
            return View(allData);
        }

        public ActionResult Index_dev()
        {
            return View(allData);
        }

        public ActionResult Organizations()
        {
            return View();
        }
    }
}