using System.Reflection.Metadata.Ecma335;

namespace UniversityMinsk
{
    class Program
    {
        static void Main(string[] args)
        { }
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
}
        /*{
            /*Address address1 = new Address("Minsk", "Staletava", 18, 24);
            Address address2 = new Address("Minsk", "Gintovta", 47, 80);
            Address address3 = new Address("Brest", "Sovetskaya", 5, 14);
            Address address4 = new Address("Gomel", "Kalinovskaga", 101, 4);
            Address address5 = new Address("Vitebsk", "Asanalieva", 19, 55);*/
            /*private const int Max_House_Number = 1000;
            private const int Max_Flat_Number = 10_000;
            private String _city;
            private String _street;
            private int _house;
            private int _flat;
            public String getCity()
            {
                get
                {
                    return _city;
                }
                
            }


            public String getStreet()
            {
                get
                {
                    return _street;
                }

            }
            public int House
            {
                get
                {
                    return _house;
                }
                set
                {

                    if (value > 0 && value < Max_House_Number)
                    {
                        _house = value;
                    }
                }
            }
            public int Flat
            {
                get
                {
                    return _flat;
                }
                set
                {
                    if (value > 0 && value < Max_Flat_Number)
                    {
                        _flat = value;
                    }

                }
            }


            public Address(String _city, String _street, int _house, int _flat)
            {
                City = _city;
                Street = _street;
                House = _house;
                Flat = _flat;
            }
        }*/
 
     
