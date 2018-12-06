using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mobileshop.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        
        public string Square(int a=13,int h=4)
        {
            double s = a * h / 2.0;
            if(a== null & h == null)
            {
                return "Вы ничего не ввели";
            }
            else
            {
                return "Площадь = " + s;
            }
           
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}