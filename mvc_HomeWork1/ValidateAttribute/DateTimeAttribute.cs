using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace mvc_HomeWork1.ValidateAttribute
{
    public sealed class DatetimeRangeAttribute : ValidationAttribute, IClientValidatable
    {
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule validationRule = new ModelClientValidationRule()
            {
                ValidationType = "datetimerange",
                ErrorMessage = FormatErrorMessage("Hi")
            };

            yield return validationRule;
        }

        public override string FormatErrorMessage(string name)
        {
            return "日期不能大於今天"+name;
        }

        public override bool IsValid(object value)
        {
            return value is DateTime && (DateTime)value < DateTime.Today;
        }
    }
}