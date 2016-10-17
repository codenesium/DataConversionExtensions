using System;

namespace Codenesium.DataConversionExtensions
{
    public static class DecimalExtensions
    {
        public static decimal ToDecimal(this decimal obj)
        {
            return obj;
        }

        public static Nullable<decimal> ToNullableDecimal(this Nullable<decimal> obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                return Convert.ToDecimal(obj);
            }
        }

        public static decimal ToDecimal(this string obj)
        {
            return ToNullableDecimal(obj) ?? 0;
        }

        public static Nullable<decimal> ToNullableDecimal(this string obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                decimal result = 0;
                if (decimal.TryParse(obj, out result))
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