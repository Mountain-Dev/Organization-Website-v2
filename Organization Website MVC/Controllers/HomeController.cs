using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Organization_Website_MVC.Models;

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
            return View();
        }

        public ActionResult Organizations()
        {
            return View(allData);
        }


        [HttpGet]
        public ActionResult RegisterOrganization()
        {
            var organization = new organization();
            return View( organization );
        }

        [HttpPost]
        public ActionResult RegisterOrganization(organization organization)
        {

            if (ModelState.IsValid)
            {

                WebsiteDB.organizations.Add(organization);

                WebsiteDB.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }


        [HttpGet]
        public ActionResult RegisterPerson()
        {
            var model = new MemberRegistrationViewModel(WebsiteDB.organizations.ToList());
            return View(model);
        }

        [HttpPost]
        public ActionResult RegisterPerson(MemberRegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                person newPerson = model.person;
                connection newConnection = model.connection;
                

                WebsiteDB.people.Add(newPerson);
                newConnection.person_id = newPerson.person_id;
                WebsiteDB.connections.Add(newConnection);
                WebsiteDB.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }


    }
}