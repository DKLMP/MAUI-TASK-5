using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_TASK_5
{
    public static class DoubleExtensions
    {
        public static string ToTrimmerString(this double target, string decimalFormat)
        {
            string strValue = target.ToString(decimalFormat);
            if (strValue.Contains("."))
            {
                strValue = strValue.TrimEnd('0');

                if (strValue.EndsWith("."))
                    strValue = strValue.TrimEnd('.');
            }
            return strValue;
        }
    }
}
