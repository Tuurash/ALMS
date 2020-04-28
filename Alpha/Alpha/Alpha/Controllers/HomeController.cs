using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alpha.Models;
using Alpha.Repository;

namespace Alpha.Controllers
{
    public class HomeController : Controller
    {

        IRepository<DonationTB> Donationrep = new DonationRepo();
        IRepository<DonorTB> Donorrep = new DonorRepo();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ReliefList()
        {
            IRepository<ReliefTB> repo = new ReliefRepo();
            return View(repo.GetAll().ToList());
        }
        public ActionResult Donate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Donate(DonationTB DTB)
        {
            DTB.DonateDate = DateTime.Now.ToString("MMMM dd, yyyy");
            Donationrep.Insert(DTB);
            Session["DonateID"] = DTB.DonateID;
            return RedirectToAction(nameof(DonationDetails), new { DTB.DonateID });
        }

        public ActionResult DonationDetails(int DonateID)
        {
            if ((Session["DonateID"]!= null))
            {
                return View(Donationrep.Get(DonateID));
            }
            else { return RedirectToAction("Donate"); }
        }

        public ActionResult Register()
        {
                return View();
         
        }
        [HttpPost]
        public ActionResult Register(DonorTB Donor)
        {
            Donorrep.Insert(Donor);
            if((Session["DonateID"] != null))
            {
                Donor.DonateID = Convert.ToInt32(Session["DonateID"]);
            }
                return RedirectToAction(nameof(DonationDetails), new { DTB.DonateID });

        }

    }
}