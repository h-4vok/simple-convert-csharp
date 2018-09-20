using SimpleConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class SimpleFloatConversions
    {
        public static float AsFloat(this object obj)
        {
            return Convert.ToSingle(obj);
        }

        public static float? AsFloatNullable(this object obj)
        {
            return SimpleConvertLambdas.AsTypeNullable(obj, o => o.AsFloat());
        }

        public static float AsSingle(this object obj)
        {
            return obj.AsFloat();
        }

        public static float? AsSingleNullable(this object obj)
        {
            return obj.AsFloatNullable();
        }
    }
}
