using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO2022.ASP.Net.MVC.Lab06.Ex01toEx02.MvcCreditApp1.Models;


namespace ITMO2022.ASP.Net.MVC.Lab06.Ex01toEx02.MvcCreditApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var allCredits = db.Credits.ToList<Credit>();
            //ViewBag.Credits = allCredits;
            GiveCredits();
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

        private CreditContext db = new CreditContext();

        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList<Credit>();
            ViewBag.Credits = allCredits;
        }

        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveCredits();
            var allBids = db.Bids.ToList<Bid>();
            ViewBag.Bids = allBids;
            return View();
        }

        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now;
            // Добавляем новую заявку в БД
            db.Bids.Add(newBid);
            // Сохраняем в БД все изменения
            db.SaveChanges();
            return "Спасибо, <b>" + newBid.Name + "</b>, " +
                "за выбор нашего банка. Ваша заявка будет " +
                "рассмотрена в течении 10 дней.";
        }
    }
}