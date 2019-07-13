using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class House
    {
        string city;
        Street street;

        public string City
        {
            set { city = value; }
            get { return city; }
        }

        public Street Street
        {
            set { street = value; }
            get { return street; }
        }

        public House(Street street, string city)
        {
            this.city = city;
            this.street = street;
        }

        public House Clone()
        {
            return this;
        }

        public House DeepClone()
        {
            return new House(this.Street.Clone() as Street, this.City);
        }
    }

    class Street:ICloneable
    {
        string str;

        public string Str { get { return str; } }

        public Street(string street)
        {
            str = street;
        }

        public object Clone()
        {
            return new Street(this.str);
        }
    }
}
