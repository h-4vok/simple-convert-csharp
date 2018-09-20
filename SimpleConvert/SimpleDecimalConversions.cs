using SimpleConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class SimpleDecimalConversions
    {
        public static decimal AsDecimal(this object obj)
        {
            return Convert.ToDecimal(obj);
        }

        public static decimal? AsDecimalNullable(this object obj)
        {
            return SimpleConvertLambdas.AsTypeNullable(obj, o => o.AsDecimal());
        }
    }
}
