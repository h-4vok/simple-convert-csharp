using SimpleConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class SimpleByteConversions
    {
        public static byte AsByte(this object obj)
        {
            return Convert.ToByte(obj);
        }

        public static byte? AsByteNullable(this object obj)
        {
            return SimpleConvertLambdas.AsTypeNullable(obj, o => o.AsByte());
        }
    }
}
