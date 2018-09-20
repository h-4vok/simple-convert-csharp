using SimpleConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class SimpleIntegerConversions
    {
        public static int? AsIntNullable(this object obj)
        {
            return SimpleConvertLambdas.AsTypeNullable(obj, o => o.AsInt());
        }

        public static int AsInt(this object obj)
        {
            return Convert.ToInt32(obj);
        }
    }
}
