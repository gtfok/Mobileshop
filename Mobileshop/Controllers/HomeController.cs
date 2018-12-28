using Mobileshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Mobileshop.Controllers
{
    public class HomeController : Controller
    {
        private MobileContext db = new MobileContext();
        public PagingInfo PagingInfo { get; set; }
        public int pagesize = 2;
        public ActionResult Index(int page = 1)
        {
            IEnumerable<Phone> phones = db.Phones;
            var Phones = phones
                .OrderBy(phone => phone.Id)
                .Skip((page - 1) * pagesize)
                .Take(pagesize);
            PagingInfo = new PagingInfo
            {
                CurrentPage = page,
                ItemsPerPage = pagesize,
                TotalItems = phones.Count()
            };
            ViewBag.Phones = Phones;
            ViewBag.PagingInfo = PagingInfo;
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
        public ActionResult Contact()
        {
            ViewBag.Message = "Контакты";
            return PartialView();
        }

    }
}