using Sarfaraz.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sarfaraz.Controllers
{
    public class bit2Controller : Controller
    {
        // GET: bit2
        mainEntities db = new mainEntities();
        public ActionResult Index2()
        {
            List<doctor> all_data = db.doctors.ToList();
            return View(all_data);
        }
        public ActionResult doc()
        {
            List<employee> all_data = db.employees.ToList();
            return View(all_data);
        }
        public ActionResult create()
        {

            return View();
        }
        public ActionResult savedata(doctor doctor)
        {
            db.doctors.Add(doctor);
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
        public ActionResult edit1(int id)
        {
            doctor doctor = db.doctors.Find(id);
            //employee data=db.employees.firstordefault(x=>x.id==id);
            return View(doctor);
        }
        public ActionResult Updatedata(doctor doctor)
        {

            db.Entry(doctor).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
        public ActionResult deletedata(int d_id)
        {
            doctor data = db.doctors.Find(d_id);
            db.doctors.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
    }
}