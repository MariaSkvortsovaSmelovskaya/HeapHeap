
namespace UniversityMinsk
{
    public class Address
    {
        private const int Max_House_Number = 1000;
        private const int Max_Flat_Number = 10_000;

        private int _house;
        private int _flat;
        public string City { get; set; }
       
        public string Street { get; set; }
        
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
        public Address(string city, string street, int house, int flat)
        {
            City = city;
            Street = street;
            House = house;
            Flat = flat;
        }

    }
}





