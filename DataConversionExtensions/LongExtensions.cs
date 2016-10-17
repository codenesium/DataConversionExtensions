﻿using System;

namespace Codenesium.DataConversionExtensions
{
    public static class LongExtentions
    {
        public static long ToLong(this int obj)
        {
            return Convert.ToInt64(obj);
        }

        public static long ToLong(this long obj)
        {
            return obj;
        }

        public static Nullable<long> ToLong(this Nullable<long> obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                return Convert.ToInt64(obj);
            }
        }

        public static long ToLong(this string obj)
        {
            return ToNullableLong(obj) ?? 0;
        }

        public static Nullable<long> ToNullableLong(this string obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                long result = 0;
                if (long.TryParse(obj, out result))
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