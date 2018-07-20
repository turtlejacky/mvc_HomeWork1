using mvc_HomeWork1.ValidateAttribute;
using System;
using System.ComponentModel.DataAnnotations;
using mvc_HomeWork1.Models.Enum;

namespace mvc_HomeWork1.Models
{
    public class AccountRecord
    {
        [Required(ErrorMessage = "此欄位為必須")]
        [DatetimeRange]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "此欄位為必須")]
        [Range(1, Int32.MaxValue, ErrorMessage = "必須輸入正整數")]
        public decimal Money { get; set; }

        [Required(ErrorMessage = "此欄位為必須")]
        [StringLength(100, MinimumLength = 0, ErrorMessage = "此欄位只接受100字以內")]
        public string Remarks { get; set; }

        [Required(ErrorMessage = "此欄位為必須")]
        public RecordType Type { get; set; }
    }
}