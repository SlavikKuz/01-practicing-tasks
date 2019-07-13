using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            House hou1 = new House(new Street("Ramberveien"), "Toensberg");

            House clone = hou1.DeepClone();

            Console.WriteLine(clone.City + " " + clone.Street.Str);

            Console.ReadKey();
        }
    }
}
