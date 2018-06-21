using System;

namespace Codenesium.DataConversionExtensions
{
    public static class ShortExtensions
    {
        /// <summary>
        /// Convert short to short. This method is useless except where
        /// we do data conversion in generaiton.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static short ToSmallInt(this short obj)
        {
            return Convert.ToInt16(obj);
        }

        /// <summary>
        /// Cast nullable short to short
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Nullable<short> ToSmallInt(this Nullable<short> obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                return Convert.ToInt16(obj);
            }
        }

    
    }
}