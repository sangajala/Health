using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sree_Health.Models
{
    public class PatientsViewModels
    {
        [Required(ErrorMessage = "Required!")]
        public string Patient { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        [EmailAddress]
        public string Mail { get; set; }
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Invalid Contact Number")]
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }
    }
    public class PatientsListModel
    {
        public string PatientID { get; set; }
        public string Patient { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Mail { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }
    }

}