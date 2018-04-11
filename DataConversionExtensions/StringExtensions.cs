using System;
using System.Globalization;
using System.Linq;
using System.Text;
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

        public static string GetValueOrDefault(this string obj)
        {
            return obj == null ? string.Empty : obj;
        }

        public static string ToUpperCaseFirstLetter(this string obj)
        {
            if (String.IsNullOrEmpty(obj))
            {
                throw new ArgumentException($"Null or empty string cannot be converted");
            }
            else if (obj.All(c => char.IsDigit(c)))
            {
                return obj;
            }
            else
            {
                StringBuilder sb = new StringBuilder(obj);
                int indexOfFirstletter = IndexOfFirstLetter(obj);
                sb[indexOfFirstletter] = obj[indexOfFirstletter].ToString().ToUpper()[0];
                return sb.ToString();
            }
        }

        public static int IndexOfFirstLetter(this string obj)
        {
            int indexOfFirstChar = -1;
            if (char.IsLetter(obj[0]))
            {
                indexOfFirstChar = 0;
            }
            else
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    if (char.IsLetter(obj[i]))
                    {
                        indexOfFirstChar = i;
                        break;
                    }
                }
            }

            return indexOfFirstChar;
        }

        public static string ToLowerCaseFirstLetter(this string obj)
        {
            if (String.IsNullOrEmpty(obj))
            {
                throw new ArgumentException($"Null or empty string cannot be converted");
            }
            else if (obj.All(c => char.IsDigit(c)))
            {
                return obj;
            }
            else
            {
                StringBuilder sb = new StringBuilder(obj);
                int indexOfFirstletter = IndexOfFirstLetter(obj);
                sb[indexOfFirstletter] = obj[indexOfFirstletter].ToString().ToLower()[0];
                return sb.ToString();
            }
        }

        public static string RemoveTrailingSlash(this string obj)
        {
            if (obj.EndsWith(@"/") || obj.EndsWith(@"\") || obj.EndsWith("/"))
            {
                return obj.Substring(0, obj.Length - 1);
            }
            else
            {
                return obj;
            }
        }

        public static string RemoveLeadingSlash(this string obj)
        {
            while (obj.StartsWith(@"\") || obj.StartsWith(@"\\") || obj.StartsWith(@"/") || obj.StartsWith("/") || obj.StartsWith("\\"))
            {
                obj = obj.Remove(0, 1);
            }
            return obj;
        }
    }
}