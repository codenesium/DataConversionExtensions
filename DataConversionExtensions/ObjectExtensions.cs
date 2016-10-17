using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;
using System.Net.Http;
using Newtonsoft.Json;

namespace Codenesium.DataConversionExtensions
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Converts a HttpContent response to a string
        /// </summary>
        /// <param name="httpContent"></param>
        /// <returns></returns>
        public static string ContentToString(this HttpContent httpContent)
        {
            var readAsStringAsync = httpContent.ReadAsStringAsync();
            return readAsStringAsync.Result;
        }

        /// <summary>
        /// Returns the int converted value of the field decorated with [Key] in a class.
        /// Refer to how System.ComponentModel.DataAnnotations.KeyAttribute works for an example
        /// Throws an argument exception if the passed object does not have a decorated field
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Nullable<int> GetNullableKey(this object obj)
        {
            if (obj == null)
            {
                return null;
            }

            Type type = obj.GetType();

            foreach (PropertyInfo property in type.GetProperties())
            {
                object[] attribute = property.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.KeyAttribute), true);
                if (attribute.Length > 0)
                {
                    object value = property.GetValue(obj, null);
                    return value.ToString().ToInt();
                }
            }

            throw new ArgumentException("The passed object does not have a property decorated with the [Key] attribute");
        }

        public static int GetKey(this object obj)
        {
            var returnValue = obj.GetNullableKey();
            return returnValue.HasValue ? returnValue.Value : 0;
        }

        /// <summary>
        /// Serializes the parameter and returns it as a json string
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJSONString(this object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
    }
}