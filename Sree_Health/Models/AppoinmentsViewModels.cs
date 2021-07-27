using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sree_Health.Models
{
    public class AppoinmentsViewModels
    {
        //public string DepartmentID { get; set; }
        //public List<DepartmentsListModel> DepartmentsList { get; set; }
        public string DoctorID { get; set; }
        public List<DoctorsListModel> DoctorsList { get; set; }
        public string PatientID { get; set; }
        public List<PatientsListModel> PatientsList { get; set; }

        [Required(ErrorMessage = "Required!")]
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }
    }
    public class AppoinmentsListModel
    {
        public string AppoinmentID { get; set; }
        public string Department { get; set; }
        public string Doctor { get; set; }
        public string Patient { get; set; }
        public int Token { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }
    }

}