using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sree_Health.Models
{
    public class DoctorsViewModels
    {
        public string DepartmentID { get; set; }
        public List<DepartmentsListModel> DepartmentsList { get; set; }

        [Required(ErrorMessage = "Required!")]
        public string Doctor { get; set; }
        public string Qualification { get; set; }
        public string Note { get; set; }
        [EmailAddress]
        public string Mail { get; set; }
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Invalid Contact Number")]
        public string Contact { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
    }

    public class DoctorsListModel
    {
        public string DoctorID { get; set; }
        public string Department { get; set; }
        public string Doctor { get; set; }
        public string Qualification { get; set; }
        public string Note { get; set; }
        public string Mail { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
    }
}