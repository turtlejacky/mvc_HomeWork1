using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc_HomeWork1.Models
{
    public class AccountRecord
    {
        public RecordType Type { get; set; }
        [Required]
        public decimal Money { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(30)]
        public string Remarks { get; set; }

    }

    public enum RecordType
    {
        [Display(Name = "支出")]
        Payout,
        [Display(Name = "收入")]
        Income

    }
}