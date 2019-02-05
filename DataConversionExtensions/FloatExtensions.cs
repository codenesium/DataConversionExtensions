using System;

namespace Codenesium.DataConversionExtensions
{
    public static class FloatExtensions
    {
        public static float ToFloat(this float obj)
        {
            return obj;
        }

        public static Nullable<float> ToNullableFloat(this Nullable<float> obj)
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

        public static float ToFloat(this string obj)
        {
            return ToNullableFloat(obj) ?? 0;
        }

        public static Nullable<float> ToNullableFloat(this string obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
				float result = 0;
                if (float.TryParse(obj, out result))
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
        }

        public static float ToFloat(this object obj)
        {
            return ToFloat(obj.ToString());
        }
    }
}