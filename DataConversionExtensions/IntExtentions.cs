using System;

namespace Codenesium.DataConversionExtensions
{
    public static class IntExtentions
    {
        /// <summary>
        /// Downcast decimal to int
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ToInt(this decimal obj)
        {
            return Convert.ToInt32(obj);
        }

        /// <summary>
        /// Downcast decimal to int
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Nullable<int> ToInt(this Nullable<decimal> obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// Downcast long to int
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ToInt(this long obj)
        {
            return Convert.ToInt32(obj);
        }

        /// <summary>
        /// Downcast nullable long to nullable int
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Nullable<int> ToInt(this Nullable<long> obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// This is a dumb function that makes code generation easier.
        /// We can apply this to all int type fields and we know they
        /// will be converted correctly if they are nullable or not.
        /// We can just say it's an int so Convert with ToInt() and it will
        /// work.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ToInt(this int obj)
        {
            return obj;
        }

        /// <summary>
        /// Cast nullable int to int
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ToInt(this Nullable<int> obj)
        {
            return ToNullableInt(obj) ?? 0;
        }

        public static Nullable<int> ToNullableInt(this Nullable<int> obj)
        {
            return obj;
        }

        public static int ToInt(this string obj)
        {
            return ToNullableInt(obj) ?? 0;
        }

        public static int? ToNullableInt(this string obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                int result = 0;
                if (Int32.TryParse(obj, out result))
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