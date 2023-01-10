
namespace UniversityMinsk
{
    public class Address
    {
        private const int Max_House_Number = 1000;
        private const int Max_Flat_Number = 10_000;
        private string city;
        private string street;
        private int house;
        private int flat;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                if (value > 0 && value < Max_House_Number)
                {
                    house = value;
                }
            }
        }
        public int Flat
        {
            get
            {
                return flat;
            }
            set
            {
                if (value > 0 && value < Max_Flat_Number)
                {
                    flat = value;
                }

            }

        }
        public Address(string city, string street, int house, int flat)
        {
            City = city;
            Street = street;
            House = house;
            Flat = flat;
        }

        public string GetStreet()
        {
            return Street;
        }

    }
}





