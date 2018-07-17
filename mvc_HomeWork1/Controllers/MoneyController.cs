using mvc_HomeWork1.Models;
using mvc_HomeWork1.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace mvc_HomeWork1.Controllers
{
    public class MoneyController : Controller
    {
        private readonly SkillTree _skillTree = new SkillTree();

        // GET: Money
        public ActionResult Index()
        {
            var moneyViewModel = new MoneyViewModel { Records = GetRecordFromDb() };
            return View(moneyViewModel);
        }

        [HttpPost]
        public ActionResult Index(MoneyViewModel recordViewModel)
        {
            recordViewModel.Records = GetRecordFromDb();
            return View(recordViewModel);
            //_skillTree.AccountBooks.Add(record);
        }

        private IEnumerable<AccountRecord> GetMoneyRecords()
        {
            var random = new Random();
            for (var i = 0; i < 50; i++)
            {
                yield return new AccountRecord()
                {
                    Date = DateTime.Now.AddDays(-i),
                    Money = random.Next(1, 100) * 100,
                    Type = i % 2 == 0 ? RecordType.Payout : RecordType.Income
                };
            }
        }

        private IEnumerable<AccountRecord> GetRecordFromDb()
        {
            return _skillTree.AccountBooks.Select(x => new AccountRecord()
            {
                Date = x.Dateee,
                Money = x.Amounttt,
                Remarks = x.Remarkkk,
                Type = (RecordType)x.Categoryyy
            });
        }
    }
}