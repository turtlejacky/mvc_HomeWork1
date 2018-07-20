using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvc_HomeWork1.Models
{
        public static class HtmlExtensions
        {
            public static HtmlString EnumDisplayNameFor(this HtmlHelper helper, System.Enum item)
            {
                var type = item.GetType();
                var member = type.GetMember(item.ToString());
                DisplayAttribute displayName = (DisplayAttribute)member[0].GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault();

                if (displayName != null)
                {
                    return new HtmlString(displayName.Name);
                }

            return new HtmlString(item.ToString());
            }
        }
}