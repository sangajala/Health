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
    public class PatientsController : Controller
    {
        // GET: Patients
        public ActionResult Patients()
        {
            List<PatientsListModel> list = LoadPatients();
            return View(list);
        }

        // GET: Patients/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Patients/Create
        public ActionResult CreatePatients()
        {
            return View();
        }

        // POST: Patients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePatients(PatientsViewModels model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    InsertPatients(model);
                    return RedirectToAction("Patients");
                }
                catch (Exception e)
                {
                    return View();
                }
            }
            return View();
        }

        // GET: Patients/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Patients/Edit/5
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

        // GET: Patients/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Patients/Delete/5
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
        private List<PatientsListModel> LoadPatients()
        {
            BusinessLib blib = new BusinessLib();
            DataTable dataTable = blib.Load_T03();
            List<PatientsListModel> list = new List<PatientsListModel>();
            PatientsListModel model;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                model = new PatientsListModel();
                model.PatientID = dataRow["PatientID"].ToString();
                model.Patient = dataRow["Patient"].ToString();
                model.Age = Convert.ToInt32(dataRow["Age"].ToString());
                model.Gender = dataRow["Gender"].ToString();
                model.Mail = dataRow["Mail"].ToString();
                model.Contact = dataRow["Contact"].ToString();
                model.Address = dataRow["Address"].ToString();
                model.Note = dataRow["Note"].ToString();
                model.Status = Convert.ToBoolean(dataRow["Status"].ToString());
                list.Add(model);
            }
            return list;
        }
        public List<PatientsListModel> LoadPatientsList()
        {
            BusinessLib blib = new BusinessLib();
            DataTable dataTable = blib.Load_T03_Patients();
            List<PatientsListModel> list = new List<PatientsListModel>();
            PatientsListModel model;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                model = new PatientsListModel();
                model.PatientID = dataRow["PatientID"].ToString();
                model.Patient = dataRow["Patient"].ToString();
                list.Add(model);
            }
            return list;
        }
        private void InsertPatients(PatientsViewModels model)
        {
            BusinessLib blib = new BusinessLib();
            PropertyLib plib = new PropertyLib();
            plib.Patient = model.Patient;
            plib.Age = model.Age;
            plib.Gender = model.Gender;
            plib.Mail = model.Mail;
            plib.Contact = model.Contact;
            plib.Address = model.Address;
            plib.Note = model.Note;
            plib.Status = model.Status;
            plib.UserID = User.Identity.GetUserId() ?? "";
            blib.Insert_T03(plib);
        }
    }
}
