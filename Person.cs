using System;
using System.Reflection.Metadata.Ecma335;
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
        UniversityMinsk.Address address;

        public Person(String firstName, String lastName, UniversityMinsk.Address address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.address = address;
        }

        public UniversityMinsk.Address getAddress()
        {
            return this.address;
        }
    }
}
