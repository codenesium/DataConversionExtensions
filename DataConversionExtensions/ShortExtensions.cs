using System;

namespace Codenesium.DataConversionExtensions
{
	public static class ShortExtensions
	{
		public static short ToShort(this short obj)
		{
			return obj;
		}

		public static long ToNullableShort(this object obj)
		{
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return ToShort(obj.ToString());
			}
		}


		public static Nullable<long> ToShort(this Nullable<short> obj)
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

		public static long ToShort(this string obj)
		{
			return ToNullableShort(obj) ?? 0;
		}

		public static Nullable<long> ToNullableShort(this string obj)
		{
			if (obj == null)
			{
				return null;
			}
			else
			{
				short result = 0;
				if (short.TryParse(obj, out result))
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