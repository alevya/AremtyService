using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AremtyContextDb _aremtyContextDb = new AremtyContextDb(); 
        public ActionResult Index()
        {
            return View();
        }


        protected override void Dispose(bool disposing)
        {
            _aremtyContextDb.Dispose();
            base.Dispose(disposing);
        }
    }
}