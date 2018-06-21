using System;
using System.Globalization;

namespace Codenesium.DataConversionExtensions
{
    public static class BooleanExtensions
    {
        public static bool ToBoolean(this bool obj)
        {
            return obj;
        }

        public static Nullable<bool> ToNullableBoolean(this Nullable<bool> obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                return obj;
            }
        }

        public static bool ToBoolean(this string obj)
        {
            return ToNullableBoolean(obj) ?? false;
        }

        public static bool? ToNullableBoolean(this string obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                bool result = false;
                if (Boolean.TryParse(obj, out result))
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}