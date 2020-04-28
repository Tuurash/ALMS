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
    }
}