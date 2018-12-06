using Mobileshop.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Mobileshop.Controllers
{
    public class HomeController : Controller
    {
        private MobileContext db = new MobileContext();
        public ActionResult Index()
        {
            IEnumerable<Phone> phones = db.Phones;
            ViewBag.Phones = phones;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int Id)
        {
            ViewBag.PhoneId = Id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase Purchase)
        {
            Purchase.Date = DateTime.Now;
            db.Purchases.Add(Purchase);
            db.SaveChanges();
            return "Спасибо за покупку," + Purchase.Owner;
        }
        public ActionResult Show()
        {
            ViewBag.Message = "хай";
            return PartialView();
        }
        public ActionResult About()
        {
            ViewBag.Message = "бом бом";
            return PartialView();
        }
        public ActionResult PartialBlock()
        {
            return PartialView();
        }

    }
}