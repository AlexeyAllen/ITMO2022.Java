using ITMO2022.ASP.Net.MVC.WebMVCR1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO2022.ASP.Net.MVC.WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index(string hel)
        {
            int hour = DateTime.Now.Hour;
            //string Greeting = hour < 12 ? "Доброе утро" : "Добрый день" + ", " + hel;
            string Greeting = ModelClass.ModelHello() + ", " + hel;
            return Greeting;
        }
    }
}