using mvc_HomeWork1.Models;
using mvc_HomeWork1.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using mvc_HomeWork1.Models.Enum;

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
            if (ModelState.IsValid)
            {
                _skillTree.AccountBooks.Add(new AccountBook()
                {
                    Id = Guid.NewGuid(),
                    Remarkkk = recordViewModel.RecordInput.Remarks,
                    Amounttt = (int)recordViewModel.RecordInput.Money,
                    Categoryyy = (int)recordViewModel.RecordInput.Type,
                    Dateee = recordViewModel.RecordInput.Date
                });
                _skillTree.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("Index");
            }

            return View(recordViewModel);
        }

        private IEnumerable<AccountRecord> GetRecordFromDb()
        {
            return _skillTree.AccountBooks.Select(x => new AccountRecord()
            {
                Date = x.Dateee,
                Money = x.Amounttt,
                Remarks = x.Remarkkk,
                Type = (RecordType)x.Categoryyy
            }).OrderByDescending(x=>x.Date);
        }
    }
}