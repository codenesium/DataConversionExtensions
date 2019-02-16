using System;
using System.Globalization;

namespace Codenesium.DataConversionExtensions
{
    public static class DateTimeExtensions
    {
        public static string ToCompleteDateString(this DateTime obj)
        {
            return obj.ToString("MM/dd/yyyy HH:mm:ss.fff",
                                CultureInfo.InvariantCulture);
        }

        public static DateTime ToDateTime(this DateTime obj)
        {
            if (obj == null)
            {
                return DateTime.MinValue;
            }
            else
            {
                return obj;
            }
        }

        public static DateTime ToNullableDateTime(this DateTime obj)
        {
            return obj;
        }

        public static DateTime ToDateTime(this Nullable<DateTime> obj)
        {
            if (obj == null)
            {
                return DateTime.MinValue;
            }
            else
            {
                return (DateTime)obj;
            }
        }

        public static Nullable<DateTime> ToNullableDateTime(this Nullable<DateTime> obj)
        {
            return obj;
        }

        public static DateTime ToDateTime(this string obj)
        {
            return ToNullableDateTime(obj) ?? DateTime.MinValue;
        }

        public static Nullable<DateTime> ToNullableDateTime(this string obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                DateTime result = DateTime.MinValue;
                if (DateTime.TryParse(obj, out result))
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