using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Car
    {
        readonly string carMake;
        readonly string model;
        readonly int year;
        readonly string color;

        public Car(string make, string model, int year, string color)
        {
            this.carMake = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public string CarMake
        {
            get { return carMake; }
        }

        public string Model
        {
            get { return model; }
        }

        public int Year
        {
            get { return year; }
        }

        public string Color
        {
            get { return color; }
        }
    }
}
