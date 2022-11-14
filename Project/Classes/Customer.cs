using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Project
{
    public class Customer
    {

        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public string phone { get; set; }

        public static List<Customer> allCustomers = new List<Customer>();


        public Customer()
        {

        }


        public Customer(int customerId, string customerName, string customerAddress, string customerCity, string customerCountry, string customerPostalCode, string customerPhone)
        {
            id = customerId;
            name = customerName;
            address = customerAddress;
            city = customerCity;
            country = customerCountry;
            postalCode = customerPostalCode;
            phone = customerPhone;
        }
    }
}
