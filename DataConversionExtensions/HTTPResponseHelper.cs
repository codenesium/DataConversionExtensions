using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Codenesium.DataConversionExtensions
{
    public static class HTTPResponseHelper
    {
        public static HttpResponseMessage ToJSONResponse(this object obj, System.Net.HttpStatusCode statusCode)
        {
            var response = new HttpResponseMessage()
            {
                StatusCode = statusCode,
                Content = new StringContent(JsonConvert.SerializeObject(obj))
            };

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return response;
        }
		
	    public static string GetHeaderValue(this HttpResponseMessage message,string key)
        {
            IEnumerable<string> values;
            string value = string.Empty;
            if (message.Headers.TryGetValues(key, out values))
            {
                value = values.FirstOrDefault();
            }
            return value;
        }
    }
}
