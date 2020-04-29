﻿using System;
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
                //donor.DonorID = Convert.ToInt32(Session["DonorID"]);  
                return View();
            }
            else 
            {
                return RedirectToAction("Register", "Home");
            }
        }

        public ActionResult DonorContribute(int donorid)
        {
            CovidDatacontext CD = new CovidDatacontext();
            if (Session["DonorID"] != null)
            {
                var list = CD.DonationTBs.Where(x => x.DonorID == donorid);
                return View(list);
            }
            else { return RedirectToAction("DonorDashboard"); }
        }

        public ActionResult Donate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Donate(DonationTB DTB,int donorid)
        {
            IRepository<DonationTB> Donationrep = new DonationRepo();

            DTB.DonateDate = DateTime.Now.ToString("MMMM dd, yyyy");
            DTB.DonorID = donorid;
            Donationrep.Insert(DTB);
            Session["DonorID"] = DTB.DonorID;
            return RedirectToAction("DonorContribute", new { DTB.DonorID });
        }
    }

}