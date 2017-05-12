using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVChomework.Models.ValidationAttributes
{
    public class 驗證電話號碼Attribute : DataTypeAttribute
    {
        private static Regex _regx = new Regex(@"\d{4}-\d{6}", RegexOptions.IgnoreCase);
        public 驗證電話號碼Attribute() : base(DataType.Text)
        {

        }

        public override bool IsValid(object value)
        {
            if(value == null)
            {
                return true;
            }
            var str = value.ToString();
            return _regx.Match(str).Length > 0;
        }
    }
}