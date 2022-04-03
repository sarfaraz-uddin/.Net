using Sarfaraz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sarfaraz.Controllers
{
    public class bitController : Controller
    {
        mainEntities db = new mainEntities();
        // GET: bit
        public ActionResult Index()
        {
            List<Std> all_data = db.Stds.ToList();
            return View(all_data);
        }
        
    }
}
