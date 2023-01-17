using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Customer(string name,
                      int age,
                      string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public override string? ToString()
        {
            return $"Driver Name: { Name }\nAge: { Age }\nAddress: { Address }";
        }
    }
}
