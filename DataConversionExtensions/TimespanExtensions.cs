using System;
using System.Globalization;

namespace Codenesium.DataConversionExtensions
{
    public static class TimespanExtensions
    {
        public static TimeSpan ToTimespan(this TimeSpan obj)
        {
            return obj;
        }

        public static Nullable<TimeSpan> ToNullableTimespan(this Nullable<TimeSpan> obj)
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

        public static TimeSpan ToTimespan(this string obj)
        {
            return ToNullableTimespan(obj) ?? default(TimeSpan);
        }

        public static TimeSpan? ToNullableTimespan(this string obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
				TimeSpan result = default(TimeSpan);
                if (TimeSpan.TryParse(obj, out result))
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