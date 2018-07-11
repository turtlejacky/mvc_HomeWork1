using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_HomeWork1.Models;
using mvc_HomeWork1.Models.ViewModel;

namespace mvc_HomeWork1.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {
            var moneyViewModel = new MoneyViewModel {Records = GetMoneyRecords()};
            return View(moneyViewModel);
        }

        private List<AccountRecord> GetMoneyRecords()
        {
            var accountRecords = new List<AccountRecord>();
            for (int i = 0; i < 50; i++)
            {
                accountRecords.Add(new AccountRecord()
                {
                    Date = DateTime.Now.AddDays(-i),
                    Money = i * 100,
                    Type = i % 2 == 0 ? RecordType.Payout : RecordType.Income

                });
            }
            return accountRecords;
        }
    }
}