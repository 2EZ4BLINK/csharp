using System;

namespace MyApplication
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        // Useful when mmanually adding data in Database
        public Customer()
        {
            Name = "No Name";
            Address = "No address";
            ContactNumber = "No contact";
        }

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

        // Method
        public void SetDetails(string name, string address, string contacnNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contacnNumber;
        }
    }
}