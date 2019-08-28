using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Rectangle
    {
        double side1 = 0;
        double side2 = 0;

        public double Area { get {return this.AreaCalculator();} }
        public double Perimeter { get { return this.PerimeterCalculator(); } }


        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        double AreaCalculator()
        {
            return side1*side2;
        }

        double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            double GetSide()
            {
                double s = 0;
                Double.TryParse(Console.ReadLine(), out s);
                return s;
            }

            bool stop = false;

            while (!stop)
            {
                Console.Write("Please, enter side 1: ");
                double s1 = GetSide();
                Console.Write("Please, enter side 2: ");
                double s2 = GetSide();

                Rectangle rec = new Rectangle(s1, s2);

                if (rec.Area > 0 && rec.Perimeter > 0)
                {
                    Console.WriteLine("Area is {0}", rec.Area);
                    Console.WriteLine("Perimeter is {0}", rec.Perimeter);
                    stop = true;
                }
                else
                    Console.WriteLine("Fail input!");
            }

            Console.ReadKey();   
        }
    }
}
