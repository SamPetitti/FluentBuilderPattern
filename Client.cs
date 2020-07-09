using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentBuilderPattern
{
    public class Client
    {
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public string StreetAddress {get;set;}
        public string Town{get; set;}
        public string ZipCode{get; set;}
        public IAccount Account {get; set;}

        // public Client(ClientBuilder builder)
        // {
        //     FirstName = builder.firstName;
        //     LastName = builder.lastName;
        //     StreetAddress = builder.streetAddress;
        //     Town = builder.town;
        //     ZipCode = builder.zipCode;
        //     Account = builder.account;
        // }
    }

    public class ClientBuilder
    {
        private Client client = new Client();
        public string firstName;
        public string lastName;
        public string streetAddress;
        public string town;
        public string zipCode;
        public Account account;

        public ClientBuilder FirstName(string firstName){
             client.FirstName = firstName;
             return this;
        }

        public ClientBuilder LastName(string lastName){
            client.LastName = lastName;
            return this;
        }

        public ClientBuilder StreetAddress(string address){
            client.StreetAddress = address;
            return this;
        }

        public ClientBuilder ZipCode(string zip){
            client.ZipCode = zip;
            return this;
        }

        public ClientBuilder Town(string town){
            client.Town = town;
            return this;
        }

        public ClientBuilder Account(Account account){
            client.Account = account;
            return this;
        }

        public Client Build() => client;
    }


}