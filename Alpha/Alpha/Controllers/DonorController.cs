using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alpha.Models;
using Alpha.Repository;

namespace Alpha.Controllers
{
    public class DonorController : Controller
    {
        IRepository<DonorTB> Donorrep = new DonorRepo();
        // GET: Donor
        public ActionResult DonorDashboard1(int DonorID)
        {
            if ((Session["DonorID"] != null))
            {
                return View(Donorrep.Get(DonorID));
            }
            else 
            {
                return RedirectToAction("Register", "Home");
            }
        }

        public ActionResult DonorDashboard(int DonorID)
        {
            return View();
        }
    }

}