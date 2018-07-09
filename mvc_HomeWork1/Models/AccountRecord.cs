using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_HomeWork1.Models
{
    public class AccountRecord
    {
        public RecordType Type { get; set; }
        public decimal Money { get; set; }
        public DateTime Date { get; set; }
        public string Remarks { get; set; }

    }

    public enum RecordType
    {
        Payout,
        Income

    }
}