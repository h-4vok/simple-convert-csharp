using SimpleConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class SimpleStringConversions
    {
        public static string AsString(this object obj)
        {
            return String.Format("{0}", obj);
        }

        public static string AsStringNullable(this object obj)
        {
            return SimpleConvertLambdas.AsTypeNullable(obj, o => o.AsString());
        }
    }
}
