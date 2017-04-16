using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codenesium.DataConversionExtensions
{
    public static class GuidExtensions
    {

        public static Guid ToGuid(this Guid obj)
        {
            return obj;
        }

        public static Nullable<Guid> ToNullableGuid(this Nullable<Guid> obj)
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

        public static Guid ToGuid(this string obj)
        {
            return ToNullableGuid(obj) ?? Guid.Empty;
        }

        public static Guid? ToNullableGuid(this string obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                Guid result = Guid.Empty;
                if (Guid.TryParse(obj, out result))
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
