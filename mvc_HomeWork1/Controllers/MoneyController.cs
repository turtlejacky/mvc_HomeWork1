using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_HomeWork1.Models.ViewModel;

namespace mvc_HomeWork1.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {
            var moneyViewModel = new MoneyViewModel();
            return View(moneyViewModel);
        }
    }
}