using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int DepartmentID { get; set; }

        public int Age { get; set; }

    }
}