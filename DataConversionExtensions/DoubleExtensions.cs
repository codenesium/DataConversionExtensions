using System;

namespace Codenesium.DataConversionExtensions
{
    public static class DoubleExtensions
    {
        public static Double ToDouble(this Double obj)
        {
            return obj;
        }

        public static Nullable<Double> ToNullableDouble(this Nullable<Double> obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                return Convert.ToDouble(obj);
            }
        }

        public static Double ToDouble(this string obj)
        {
            return ToNullableDouble(obj) ?? 0;
        }

        public static Nullable<Double> ToNullableDouble(this string obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                Double result = 0;
                if (Double.TryParse(obj, out result))
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
        }

        public static Double ToDouble(this object obj)
        {
            return ToDouble(obj.ToString());
        }
    }
}