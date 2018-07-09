using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_HomeWork1.Models.ViewModel
{
    public class MoneyViewModel
    {
        public List<AccountRecord> Records=>new List<AccountRecord>()
        {
            new AccountRecord(){ Type = RecordType.Payout, Money = 300, Date = new DateTime(2016,01,01)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 16000, Date = new DateTime(2016,01,02)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 8000, Date = new DateTime(2016,01,03)},
            new AccountRecord(){ Type = RecordType.Income, Money = 800, Date = new DateTime(2016,01,04)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 80, Date = new DateTime(2016,01,05)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 8, Date = new DateTime(2016,01,06)},
            new AccountRecord(){ Type = RecordType.Income, Money = 400, Date = new DateTime(2016,01,07)},
            new AccountRecord(){ Type = RecordType.Income, Money = 200, Date = new DateTime(2016,01,08)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 1000, Date = new DateTime(2016,01,09)},
            new AccountRecord(){ Type = RecordType.Income, Money = 8500, Date = new DateTime(2016,01,10)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 300, Date = new DateTime(2016,01,01)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 16000, Date = new DateTime(2016,01,02)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 8000, Date = new DateTime(2016,01,03)},
            new AccountRecord(){ Type = RecordType.Income, Money = 800, Date = new DateTime(2016,01,04)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 80, Date = new DateTime(2016,01,05)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 8, Date = new DateTime(2016,01,06)},
            new AccountRecord(){ Type = RecordType.Income, Money = 400, Date = new DateTime(2016,01,07)},
            new AccountRecord(){ Type = RecordType.Income, Money = 200, Date = new DateTime(2016,01,08)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 1000, Date = new DateTime(2016,01,09)},
            new AccountRecord(){ Type = RecordType.Income, Money = 8500, Date = new DateTime(2016,01,10)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 300, Date = new DateTime(2016,01,01)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 16000, Date = new DateTime(2016,01,02)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 8000, Date = new DateTime(2016,01,03)},
            new AccountRecord(){ Type = RecordType.Income, Money = 800, Date = new DateTime(2016,01,04)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 80, Date = new DateTime(2016,01,05)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 8, Date = new DateTime(2016,01,06)},
            new AccountRecord(){ Type = RecordType.Income, Money = 400, Date = new DateTime(2016,01,07)},
            new AccountRecord(){ Type = RecordType.Income, Money = 200, Date = new DateTime(2016,01,08)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 1000, Date = new DateTime(2016,01,09)},
            new AccountRecord(){ Type = RecordType.Income, Money = 8500, Date = new DateTime(2016,01,10)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 300, Date = new DateTime(2016,01,01)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 16000, Date = new DateTime(2016,01,02)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 8000, Date = new DateTime(2016,01,03)},
            new AccountRecord(){ Type = RecordType.Income, Money = 800, Date = new DateTime(2016,01,04)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 80, Date = new DateTime(2016,01,05)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 8, Date = new DateTime(2016,01,06)},
            new AccountRecord(){ Type = RecordType.Income, Money = 400, Date = new DateTime(2016,01,07)},
            new AccountRecord(){ Type = RecordType.Income, Money = 200, Date = new DateTime(2016,01,08)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 1000, Date = new DateTime(2016,01,09)},
            new AccountRecord(){ Type = RecordType.Income, Money = 8500, Date = new DateTime(2016,01,10)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 300, Date = new DateTime(2016,01,01)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 16000, Date = new DateTime(2016,01,02)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 8000, Date = new DateTime(2016,01,03)},
            new AccountRecord(){ Type = RecordType.Income, Money = 800, Date = new DateTime(2016,01,04)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 80, Date = new DateTime(2016,01,05)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 8, Date = new DateTime(2016,01,06)},
            new AccountRecord(){ Type = RecordType.Income, Money = 400, Date = new DateTime(2016,01,07)},
            new AccountRecord(){ Type = RecordType.Income, Money = 200, Date = new DateTime(2016,01,08)},
            new AccountRecord(){ Type = RecordType.Payout, Money = 1000, Date = new DateTime(2016,01,09)},
            new AccountRecord(){ Type = RecordType.Income, Money = 8500, Date = new DateTime(2016,01,10)},
        };
    }
}