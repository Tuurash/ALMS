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
        public ActionResult DonorDashboard(DonorTB donor)
        {
            if ((Session["DonorID"] != null))
            {
                donor.DonorID = Convert.ToInt32(Session["DonorID"]);
                
                return View();
            }
            else 
            {
                return RedirectToAction("Register", "Home");
            }
        }
    }

}