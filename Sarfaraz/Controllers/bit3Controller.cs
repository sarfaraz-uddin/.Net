using Sarfaraz.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sarfaraz.Controllers
{
    public class bit3Controller : Controller
    {
        // GET: bit3
        mainEntities db = new mainEntities();
        public ActionResult Index3()
        {
            List<employee_salary_details> all_data = db.employee_salary_details.ToList();
            return View(all_data);
        }
        public ActionResult salary()
        {
            List<employee_salary_details> all_data = db.employee_salary_details.ToList();
            return View(all_data);
        }
        public ActionResult create()
        {

            return View();
        }
        public ActionResult savedata(employee_salary_details employee_Salary_Details)
        {
            db.employee_salary_details.Add(employee_Salary_Details);
            db.SaveChanges();
            return RedirectToAction("Index3");
        }
        public ActionResult edit2(int id)
        {
            employee_salary_details employee_Salary_Details = db.employee_salary_details.Find(id);
            //employee data=db.employees.firstordefault(x=>x.id==id);
            return View(employee_Salary_Details);
        }
        public ActionResult Updatedata(employee_salary_details employee_Salary_Details)
        {

            db.Entry(employee_Salary_Details).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index3");
        }
        public ActionResult deletedata(int id)
        {
            employee_salary_details data = db.employee_salary_details.Find(id);
            db.employee_salary_details.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index3");
        }
    }
}