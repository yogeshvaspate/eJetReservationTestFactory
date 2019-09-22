using System;
using UnitTests.ApplicationCore.Entities;

namespace UnitTestExecute
{
    class Program
    {
        internal static string baseURI = "http://localhost:49535/api/";

        static void Main(string[] args)
        {
            RunCreateCustomerTest();
            Console.ReadKey();
        }

        internal static void RunCreateCustomerTest()
        {
            CreateCustomer tCreateCustomer = new CreateCustomer();
            tCreateCustomer.TestCreateCustomer(baseURI);
        }
    }
}
