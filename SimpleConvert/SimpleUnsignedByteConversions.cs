using SimpleConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class SimpleUnsignedByteConversions
    {
        public static sbyte AsSByte(this object obj)
        {
            return Convert.ToSByte(obj);
        }

        public static sbyte? AsSByteNullable(this object obj)
        {
            return SimpleConvertLambdas.AsTypeNullable(obj, o => o.AsSByte());
        }
    }
}
