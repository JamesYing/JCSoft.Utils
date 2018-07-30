using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.Utils.Extensions
{
    public static class ConvertExtensions
    {
        public static Int32 ToInt32(this object obj, Int32 defaultValue = 0)
        {
            if (Int32.TryParse(obj.ToString(), out Int32 outValue))
            {
                return outValue;
            }

            return defaultValue;
        }
    }
}
