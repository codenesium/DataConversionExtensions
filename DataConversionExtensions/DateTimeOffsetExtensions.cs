using System;
using System.Globalization;

namespace Codenesium.DataConversionExtensions
{
    public static class DateTimeOffsetExtensions
    {
        public static DateTimeOffset ToDateTimeOffset(this DateTimeOffset obj)
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

        public static DateTimeOffset ToNullableDateTime(this DateTimeOffset obj)
        {
            return obj;
        }

        public static DateTimeOffset ToDateTime(this Nullable<DateTimeOffset> obj)
        {
            if (obj == null)
            {
				return DateTimeOffset.MinValue;
            }
            else
            {
				return (DateTimeOffset)obj;
            }
        }

        public static Nullable<DateTimeOffset> ToNullableDateTimeOffset(this Nullable<DateTimeOffset> obj)
        {
            return obj;
        }

        public static DateTimeOffset ToDateTimeOffset(this string obj)
        {
            return ToNullableDateTimeOffset(obj) ?? DateTimeOffset.MinValue;
        }

        public static Nullable<DateTimeOffset> ToNullableDateTimeOffset(this string obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
				DateTimeOffset result = DateTimeOffset.MinValue;
                if (DateTimeOffset.TryParse(obj, out result))
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