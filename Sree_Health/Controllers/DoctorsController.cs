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
    public class DoctorsController : Controller
    {
        DepartmentsController departments = new DepartmentsController();
        // GET: Doctors
        public ActionResult Doctors()
        {
            List<DoctorsListModel> list = LoadDoctors();
            return View(list);
        }

        // GET: Doctors/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Doctors/Create
        public ActionResult CreateDoctors()
        {
            DoctorsViewModels model = new DoctorsViewModels();
            model.DepartmentsList = departments.LoadDepartmentsList();
            return View(model);
        }

        // POST: Doctors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDoctors(DoctorsViewModels model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    InsertDoctors(model);
                    return RedirectToAction("Doctors");
                }
                catch (Exception e)
                {
                    return View();
                }
            }
            return View();
        }

        // GET: Doctors/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Doctors/Edit/5
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

        // GET: Doctors/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Doctors/Delete/5
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
        private List<DoctorsListModel> LoadDoctors()
        {
            BusinessLib blib = new BusinessLib();
            DataTable dataTable = blib.Load_T02();
            List<DoctorsListModel> list = new List<DoctorsListModel>();
            DoctorsListModel model;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                model = new DoctorsListModel();
                model.DoctorID = dataRow["DoctorID"].ToString();
                model.Department = dataRow["Department"].ToString();
                model.Doctor = dataRow["Doctor"].ToString();
                model.Qualification = dataRow["Qualification"].ToString();
                model.Note = dataRow["Note"].ToString();
                model.Mail = dataRow["Mail"].ToString();
                model.Contact = dataRow["Contact"].ToString();
                model.Address = dataRow["Address"].ToString();
                model.Status = Convert.ToBoolean(dataRow["Status"].ToString());
                list.Add(model);
            }
            return list;
        }
        public List<DoctorsListModel> LoadDoctorsList()
        {
            BusinessLib blib = new BusinessLib();
            DataTable dataTable = blib.Load_T02_Doctors();
            List<DoctorsListModel> list = new List<DoctorsListModel>();
            DoctorsListModel model;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                model = new DoctorsListModel();
                model.DoctorID = dataRow["DoctorID"].ToString();
                model.Doctor = dataRow["Doctor"].ToString();
                list.Add(model);
            }
            return list;
        }

        private void InsertDoctors(DoctorsViewModels model)
        {
            BusinessLib blib = new BusinessLib();
            PropertyLib plib = new PropertyLib();
            plib.DepartmentID = model.DepartmentID;
            plib.Doctor = model.Doctor;
            plib.Qualification = model.Qualification;
            plib.Note = model.Note;
            plib.Mail = model.Mail;
            plib.Contact = model.Contact;
            plib.Address = model.Address;
            plib.Status = model.Status;
            plib.UserID = User.Identity.GetUserId() ?? "";
            blib.Insert_T02(plib);
        }
    }
}
