using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApplication.Models
{
    [Bind(Exclude = "ID")]
    public class Department
    {
      
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [DisplayName("Department Name")]
        [Required(ErrorMessage ="Department is Required")]
        [StringLength(100,MinimumLength =4)]
        public int Name { get; set; }
        public int Address { get; set; }
        [EmailAddress]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public int EmailAddres { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("EmailAddres")]
        public int ConfirmEmail { get; set; }
        [Phone]
        public int ContacNo { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(3000, 10000000, ErrorMessage = "Budget must be between 3000 and 10000000")]
        public int Budget { get; set; }

        [DataType(DataType.Password)]
        public int Password { get; set; }

        [ReadOnly(true)]
        public Decimal Income { get; set; }
    }
}