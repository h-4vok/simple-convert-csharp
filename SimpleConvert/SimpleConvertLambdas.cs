using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleConvert
{
    internal static class SimpleConvertLambdas
    {
        internal static T AsTypeNullable<T>(object obj, Func<object, T> convertClosure)
        {
            if (obj == null)
                return default(T);

            return convertClosure(obj);
        }
    }
}
