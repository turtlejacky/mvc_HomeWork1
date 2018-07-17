using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_HomeWork1.Models.ViewModel
{
    public class MoneyViewModel
    {
        public AccountRecord RecordInput { get; set; }
        public IEnumerable<AccountRecord> Records { get; set; }
    }
}