using System.Reflection.Metadata.Ecma335;

namespace UniversityMinsk
{
        public class Address
        {
            public String city;
            public String street;
            public int house;
            public int flat;

            public Address(string city, string street, int house, int flat)
            {
                this.city = city;
                this.street = street;
                this.house = house;
                this.flat = flat;
            }

            public String getStreet()
            {
                return this.street;
            }
        }
    }

    

                
