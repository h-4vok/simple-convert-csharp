using SimpleConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class SimpleUnsignedIntegerConversions
    {
        public static uint AsUInt(this object obj)
        {
            return Convert.ToUInt32(obj);
        }

        public static uint? AsUIntNullable(this object obj)
        {
            return SimpleConvertLambdas.AsTypeNullable(obj, o => o.AsUInt());
        }
    }
}
