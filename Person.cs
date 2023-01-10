
namespace UniversityMinsk
{
    internal class Person
    {

        public string FirstName;
        public string LastName;
        Address address;

        public Person(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            address = address;
        }

        public Address GetAddress()
        {
            return address;
        }
    }
}
