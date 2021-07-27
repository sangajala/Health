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
    public class DepartmentsController : Controller
    {
        // GET: Default
        public ActionResult Departments()
        {
            List<DepartmentsListModel> list = LoadDepartments();
            return View(list);
        }

        // GET: Default/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Default/Create
        public ActionResult CreateDepartments()
        {
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDepartments(DepartmentsViewModels model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    InsertDepartments(model);
                    return RedirectToAction("Departments");
                }
                catch (Exception e)
                {
                    return View();
                }
            }
            return View();
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
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

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
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
        #region LIST
        private List<DepartmentsListModel> LoadDepartments()
        {
            BusinessLib blib = new BusinessLib();
            DataTable dataTable = blib.Load_T01();
            List<DepartmentsListModel> list = new List<DepartmentsListModel>();
            DepartmentsListModel model;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                model = new DepartmentsListModel();
                model.DepartmentID = dataRow["DepartmentID"].ToString();
                model.Department = dataRow["Department"].ToString();
                model.Status = Convert.ToBoolean(dataRow["Status"].ToString());
                list.Add(model);
            }
            return list;
        }
        public List<DepartmentsListModel> LoadDepartmentsList()
        {
            BusinessLib blib = new BusinessLib();
            DataTable dataTable = blib.Load_T01_Departments();
            List<DepartmentsListModel> list = new List<DepartmentsListModel>();
            DepartmentsListModel model;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                model = new DepartmentsListModel();
                model.DepartmentID = dataRow["DepartmentID"].ToString();
                model.Department = dataRow["Department"].ToString();
                list.Add(model);
            }
            return list;
        }

        #endregion LIST
        private void InsertDepartments(DepartmentsViewModels model)
        {
            BusinessLib blib = new BusinessLib();
            PropertyLib plib = new PropertyLib();
            plib.Department = model.Department;
            plib.Status = model.Status;
            plib.UserID = User.Identity.GetUserId() ?? "";
            blib.Insert_T01(plib);
        }

    }
}
