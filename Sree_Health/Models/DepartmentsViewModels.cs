using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sree_Health.Models
{
    public class DepartmentsViewModels
    {
        [Required(ErrorMessage = "Required!")]
        public string Department { get; set; }
        public bool Status { get; set; }
    }

    public class DepartmentsListModel
    {
        public string DepartmentID { get; set; }
        public string Department { get; set; }
        public bool Status { get; set; }
    }

}