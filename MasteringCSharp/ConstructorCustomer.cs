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
        public Customer(string name, string address, string contactNumber = "123") {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public Customer(string name)
        {
            Name = name;
        }

        // Method

        // Named Parameter:
        // Customer maki = new Customer();
        // maki.SetDetails(name: "maki", address: "shibuya", contactNumber: "12345");
        
        public void SetDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}