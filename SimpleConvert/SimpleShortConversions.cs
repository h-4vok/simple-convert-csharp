using SimpleConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class SimpleShortConversions
    {
        public static short AsShort(this object obj)
        {
            return Convert.ToInt16(obj);
        }

        public static short? AsShortNullable(this object obj)
        {
            return SimpleConvertLambdas.AsTypeNullable(obj, o => o.AsShort());
        }
    }
}
