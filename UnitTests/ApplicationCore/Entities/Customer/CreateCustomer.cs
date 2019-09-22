using System;
using NUnit.Framework;
using System.Net.Http;
using Newtonsoft.Json;
using UnitTests.Common;

namespace UnitTests.ApplicationCore.Entities
{
    [TestFixture]
    public class CreateCustomer
    {
        private int CustomerId = 1;
        private string Title = "Mr";
        private string FirstName = "Colin";
        private string LastName = "Parker";

        [Test]
        public bool TestCreateCustomer(string baseURI)
        {
            HttpResponseMessage jResponse = null;
            try
            {
                CallService oWebAPICall = new CallService();

                jResponse = oWebAPICall.Call(baseURI, "CreateCustomer/" + CustomerId + "/" + Title + "/" + FirstName + "/" + LastName);
                string jsonResponse = jResponse.Content.ReadAsAsync<string>().Result;
                ResultBool rt = JsonConvert.DeserializeObject<ResultBool>(jsonResponse);

                jResponse.Dispose();

                return rt.Value;
            }
            catch(Exception e)
            {
                Console.Write("Test failed with exception: " + e.Message);
                return false;
            }
            finally
            {
                jResponse.Dispose();
            }
        }
    }

}
