using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace UnitTests.Common
{
    public class CallService : IDisposable
    {
        HttpClient client;
        public HttpResponseMessage Call(string BaseURI, string ServiceName)
        {
            string serviceURI = BaseURI + ServiceName;
            string urlParameters = "";
            client = new HttpClient();
            client.BaseAddress = new Uri(serviceURI);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client.GetAsync(urlParameters).Result;
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
