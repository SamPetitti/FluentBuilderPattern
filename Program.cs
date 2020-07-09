using System.Xml.Linq;
using System.Reflection;
using System;

namespace FluentBuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var client= new ClientBuilder()
            .FirstName("Sam")
            .LastName("Petitti")
            .StreetAddress("1234 Main St.")
            .ZipCode("06070")
            .Account(new Account())
            .Town("Simsbury")
            .Build();

            WriteProp("FirstName",client.FirstName);
            WriteProp("LastName", client.LastName);
            WriteProp("StreetAddress",client.StreetAddress);
            WriteProp("ZipCode", client.ZipCode);
            WriteProp("Town", client.Town);
            WriteProp("Current Balance",client.Account.Balance.ToString());

        }

        public static void WriteProp(string propType, string prop){
            Console.WriteLine($"{propType} is {prop}");
        }
    }
}
