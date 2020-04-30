using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alpha.Models;
using Alpha.Repository;

namespace Alpha.Controllers
{
    public class AdminController : Controller
    {
        IRepository<AdminTB> Donorrep = new AdminRepo();
        // GET: Donor
        public ActionResult AdminDashboard(AdminTB admin)
        {
            if ((Session["AdminID"] != null))
            {
                //admin.AdminID = Convert.ToInt32(Session["AdminID"]);

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logout()
        {
            if (Session["AdminID"] != null && Session["AdminName"] != null)
            {
                Session["AdminID"] = string.Empty;
                Session["AdminName"] = string.Empty;

                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");
        }
    }

}