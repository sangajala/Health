using ClassLibrary_SreeHealth;
using Microsoft.AspNet.Identity;
using Sree_Health.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sree_Health.Controllers
{
    public class AppoinmentsController : Controller
    {
        DepartmentsController departments = new DepartmentsController();
        DoctorsController doctors = new DoctorsController();
        PatientsController patients = new PatientsController();
        // GET: Appoinments
        public ActionResult Appoinments()
        {
            List<AppoinmentsListModel> list = LoadAppoinments();
            return View(list);
        }

        // GET: Appoinments/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Appoinments/Create
        public ActionResult CreateAppoinments()
        {
            AppoinmentsViewModels model = new AppoinmentsViewModels();
            //model.DepartmentsList = departments.LoadDepartmentsList();
            model.DoctorsList = doctors.LoadDoctorsList();
            model.PatientsList = patients.LoadPatientsList();
            return View(model);
        }

        // POST: Appoinments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAppoinments(AppoinmentsViewModels model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    InsertAppoinments(model);
                    return RedirectToAction("Appoinments");
                }
                catch (Exception e)
                {
                    return View();
                }
            }
            return RedirectToAction("Appoinments");
        }

        // GET: Appoinments/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Appoinments/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Appoinments/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Appoinments/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        private List<AppoinmentsListModel> LoadAppoinments()
        {
            BusinessLib blib = new BusinessLib();
            DataTable dataTable = blib.Load_T04();
            List<AppoinmentsListModel> list = new List<AppoinmentsListModel>();
            AppoinmentsListModel model;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                model = new AppoinmentsListModel();
                model.AppoinmentID = dataRow["AppoinmentID"].ToString();
                model.Department = dataRow["Department"].ToString();
                model.Doctor = dataRow["Doctor"].ToString();
                model.Patient = dataRow["Patient"].ToString();
                model.Token = Convert.ToInt32(dataRow["Token"].ToString());
                model.Date = Convert.ToDateTime(dataRow["Date"].ToString());
                model.Note = dataRow["Note"].ToString();
                model.Status = Convert.ToBoolean(dataRow["Status"].ToString());
                list.Add(model);
            }
            return list;
        }
        private void InsertAppoinments(AppoinmentsViewModels model)
        {
            BusinessLib blib = new BusinessLib();
            PropertyLib plib = new PropertyLib();
            //plib.DepartmentID = model.DepartmentID;
            plib.DoctorID = model.DoctorID;
            plib.PatientID = model.PatientID;
            plib.Date = model.Date;
            plib.Note = model.Note;
            plib.Status = model.Status;
            plib.UserID = User.Identity.GetUserId() ?? "";
            blib.Insert_T04(plib);
        }
    }
}
