using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UniversityMinsk
{
    internal class Person
    {

        public String FirstName;
        public String LastName;
        Address address;

        public Person(String firstName, String lastName, Address address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }

        public Address GetAddress()
        {
            return this.address();
        }
    }
}
