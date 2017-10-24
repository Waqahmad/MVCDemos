using DemoApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DemoApplication.Controllers
{
    public class ActionResultExamplesController : Controller
    {
        // GET: ActionResultExamples

        //Return basic View
        List<Employee> Emplist = new List<Employee>
        {
             new Employee{Id=1,Name="Ali",Age=22,DepartmentID=1},
             new Employee{Id=2,Name="Ahmad",Age=22,DepartmentID=1},
             new Employee{Id=3,Name="Imran",Age=22,DepartmentID=1},
             new Employee{Id=4,Name="Kamran",Age=22,DepartmentID=1},
             new Employee{Id=5,Name="Zaid",Age=22,DepartmentID=1},
             new Employee{Id=6,Name="Haris",Age=22,DepartmentID=1},
             new Employee{Id=7,Name="Bilal",Age=22,DepartmentID=1},

        };
        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        //Return Partial View
        public PartialViewResult PartialIndex(int? id)
        {
            return PartialView("PagerPartial",id);
        }
        //Redirect Result
        public RedirectResult TestRedirect()
        {
            return Redirect("Home/Contact");
        }

        public ActionResult TestAction()
        {
           // return RedirectToAction("Contact", "Home");

           // return RedirectToAction("Home", new RouteValueDictionary(
            //new { controller = "Home", action = "Index", Id = "Hello" }));

            //return RedirectToAction("Action","controller", new {@id=id});

            return RedirectToAction("PartialIndex", new { id = 99 });
        }

        public ActionResult TestJson()
        {
            var jsonresult = Json(Emplist, JsonRequestBehavior.AllowGet);
            return Json(Emplist, JsonRequestBehavior.AllowGet);
        }

        public ActionResult FileResult()
        {
            return File("Web.Config", "text");
        }
    }
}