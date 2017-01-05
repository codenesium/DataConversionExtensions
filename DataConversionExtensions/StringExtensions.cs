using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Codenesium.DataConversionExtensions
{
    public static class StringExtensions
    {
        public static bool IsValidJson(this string obj)
        {
            try
            {
                JObject.Parse(obj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}