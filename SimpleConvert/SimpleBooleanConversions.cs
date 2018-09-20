using SimpleConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class SimpleConvertExtensions
    {
        public static bool AsBool(this object obj)
        {
            return Convert.ToBoolean(obj);
        }

        public static bool? AsBoolNulleable(this object obj)
        {
            return SimpleConvertLambdas.AsTypeNullable(obj, o => o.AsBool());
        }
    }
}
