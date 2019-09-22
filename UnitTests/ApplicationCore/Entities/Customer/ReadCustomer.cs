using System;
using NUnit.Framework;
using System.Net.Http;
using Newtonsoft.Json;
using UnitTests.Common;

namespace UnitTests.ApplicationCore.Entities
{
    [TestFixture]
    public class ReadCustomer
    {
        [Test]
        public bool TestReadCustomer(string baseURI)
        {
            try
            {
                CallService oWebAPICall = new CallService();

                HttpResponseMessage jResponse = oWebAPICall.Call(baseURI, "ReadCustomer/1");
                string jsonResponse = jResponse.Content.ReadAsAsync<string>().Result;
                ResultBool rt = JsonConvert.DeserializeObject<ResultBool>(jsonResponse);

                jResponse.Dispose();

                return rt.Value;
            }
            catch (Exception e)
            {
                Console.Write("Test failed with exception: " + e.Message);
                return false;
            }
        }
    }

}
