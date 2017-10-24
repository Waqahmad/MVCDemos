using DemoApplication.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
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
            //Strongly Type View
            return View(Emplist);
        }

        //Dynamic View
        public ActionResult Detail(int id)
        {
            // New feature to add Function with in Function
             int Sum(int x, int y)
            {
                return x + y;
            }
            dynamic expendo = new ExpandoObject();

            Func<int, int, int> add = Sum;

            Func<int, int, int> Calululate =
                ((Gross, Basic) => Gross + Basic);

            Employee individualemploye =Emplist.Find(x => x.Id == id);



            expendo.EmployeeInfo = individualemploye;
            expendo.DepartmentName = "Hr";
            expendo.UserName = "Waqar";
            expendo.Salary= Calululate(10, 10);



             


            return View(expendo);
        }

        public ActionResult Create(Employee emp)
        {
            return View();
        }
    }
}