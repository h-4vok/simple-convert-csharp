using SimpleConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class SimpleLongConversions
    {
        public static long AsLong(this object obj)
        {
            return Convert.ToInt64(obj);
        }

        public static long? AsLongNullable(this object obj)
        {
            return SimpleConvertLambdas.AsTypeNullable(obj, o => o.AsLong());
        }
    }
}
