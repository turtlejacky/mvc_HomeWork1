using System.ComponentModel.DataAnnotations;

namespace mvc_HomeWork1.Models.Enum
{
    public enum RecordType
    {
        [Display(Name = "支出")]
        Payout,

        [Display(Name = "收入")]
        Income
    }
}