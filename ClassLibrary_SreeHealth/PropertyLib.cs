using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_SreeHealth
{
    public class PropertyLib
    {
        string _DepartmentID;
        string _Department;
        bool _Status;
        DateTime _CreateDate;
        DateTime _UpdateDate;
        string _UserID;
        string _DoctorID;
        string _Doctor;
        string _Qualification;
        string _Note;
        string _Mail;
        string _Contact;
        string _Address;
        string _PatientID;
        string _Patient;
        int _Age;
        string _Gender;
        DateTime _Date;


        #region Encapsulated

        public string DepartmentID { get => _DepartmentID; set => _DepartmentID = value; }
        public string Department { get => _Department; set => _Department = value; }
        public bool Status { get => _Status; set => _Status = value; }
        public DateTime CreateDate { get => _CreateDate; set => _CreateDate = value; }
        public DateTime UpdateDate { get => _UpdateDate; set => _UpdateDate = value; }
        public string UserID { get => _UserID; set => _UserID = value; }
        public string Doctor { get => _Doctor; set => _Doctor = value; }
        public string Qualification { get => _Qualification; set => _Qualification = value; }
        public string Note { get => _Note; set => _Note = value; }
        public string Mail { get => _Mail; set => _Mail = value; }
        public string Contact { get => _Contact; set => _Contact = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Patient { get => _Patient; set => _Patient = value; }
        public int Age { get => _Age; set => _Age = value; }
        public string Gender { get => _Gender; set => _Gender = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public string PatientID { get => _PatientID; set => _PatientID = value; }
        public string DoctorID { get => _DoctorID; set => _DoctorID = value; }







        #endregion Encapsulated
    }
}
