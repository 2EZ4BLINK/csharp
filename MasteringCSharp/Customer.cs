using System;

namespace MyApplication
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Custom Constructor
        public Customer(string name, string address, string contacnNumber) {
            Name = name;
            Address = address;
            ContactNumber = contacnNumber;
        }

        public Customer(string name)
        {
            Name = name;
        }
    }
}