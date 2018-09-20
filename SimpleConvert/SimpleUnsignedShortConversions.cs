using SimpleConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class SimpleUnsignedShortConversions
    {
        public static ushort AsUShort(this object obj)
        {
            return Convert.ToUInt16(obj);
        }

        public static ushort? AsUShortNullable(this object obj)
        {
            return SimpleConvertLambdas.AsTypeNullable(obj, o => o.AsUShort());
        }
    }
}
