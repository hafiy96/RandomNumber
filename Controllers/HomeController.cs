using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        // GET: Home
        public ActionResult Index()
        {

            int randomNumber;
            Random randm = new Random();
            randomNumber = randm.Next(1,21);
            if (randomNumber == 1)
                ViewBag.Result = "Alpha";
            if (randomNumber == 2)
                ViewBag.Result = "Gamma";
            if (randomNumber == 3)
                ViewBag.Result = "Delta";
            if (randomNumber == 4)
                ViewBag.Result = "Eta";
            if (randomNumber == 5)
                ViewBag.Result = "Iota";
            if (randomNumber == 6)
                ViewBag.Result = "Mu";
            if (randomNumber == 7)
                ViewBag.Result = "Beta";
            if (randomNumber == 8)
                ViewBag.Result = "Kappa";
            if (randomNumber == 9)
                ViewBag.Result = "Lambda";
            if (randomNumber == 10)
                ViewBag.Result = "Upsilon";
            if (randomNumber == 11)
                ViewBag.Result = "Pi";
            if (randomNumber == 12)
                ViewBag.Result = "Sigma";
            if (randomNumber == 13)
                ViewBag.Result = "Xi";
            if (randomNumber == 14)
                ViewBag.Result = "Chi";
            if (randomNumber == 15)
                ViewBag.Result = "Psi";
            if (randomNumber == 16)
                ViewBag.Result = "Epsilon";
            if (randomNumber == 17)
                ViewBag.Result = "Beta Tau";
            if (randomNumber == 18)
                ViewBag.Result = "Omicron";
            if (randomNumber == 19)
                ViewBag.Result = "Alpha Mu";
            if (randomNumber == 20)
                ViewBag.Result = "Delta Iota";
            

            ViewBag.randomNumber = randomNumber;
          

          
            return View();
        }
    }
}