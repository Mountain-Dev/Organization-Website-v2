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

            allData.Add(WebsiteDB.connections);
            allData.Add(WebsiteDB.organizations);
            allData.Add(WebsiteDB.people);

        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Organizations()
        {
            return View();
        }
    }
}