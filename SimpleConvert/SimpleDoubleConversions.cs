using SimpleConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class SimpleDoubleConversions
    {
        public static double AsDouble(this object obj)
        {
            return Convert.ToDouble(obj);
        }

        public static double? AsDoubleNullable(this object obj)
        {
            return SimpleConvertLambdas.AsTypeNullable(obj, o => o.AsDouble());
        }
    }
}
