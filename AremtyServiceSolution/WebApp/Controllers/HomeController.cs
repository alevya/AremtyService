using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using WebApp.Models.Aremty;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly AremtyContextDb _aremtyContextDb = new AremtyContextDb(); 

        [HttpGet]
        public ActionResult Index(bool isLogIn = false)
        {
            //return View(_aremtyContextDb.GuiDashboards);
            return View(ViewData["isLogIn"] = isLogIn);
        }

        [HttpGet]
        public ActionResult LogIn()
        {
            return Index(true);
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            Index();
            return View("Index");
        }
        //protected override void Dispose(bool disposing)
        //{
        //    _aremtyContextDb.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}