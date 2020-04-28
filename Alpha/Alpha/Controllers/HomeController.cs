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
            Donationrep.Insert(DTB);
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
    }
}