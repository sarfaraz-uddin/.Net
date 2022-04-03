using Sarfaraz.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sarfaraz.Controllers
{
    public class bit1Controller : Controller
    {
        mainEntities db = new mainEntities();
        // GET: bit1
        public ActionResult Index1()
        {
            List<employee> all_data = db.employees.ToList();
            return View(all_data);
        }

        public ActionResult hahhahah()
        {
            List<employee> all_data = db.employees.ToList();
            return View(all_data);
        }
        
        public ActionResult create()
        {
            
            return View();
        }
        public ActionResult savedata(employee employee)
        {
            db.employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index1");
        }
        public ActionResult edit(int id)
        {
            employee employee= db.employees.Find(id);
            //employee data=db.employees.firstordefault(x=>x.id==id);
            return View(employee);
        }
        public ActionResult Updatedata(employee employee)
        { 
           
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index1");
        }
    }
}