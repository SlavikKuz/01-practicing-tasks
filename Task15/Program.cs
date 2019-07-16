using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar cal = new Calendar();

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Select month:");

            int ind = 1;
            try
            {
                ind = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a number!");
                Console.WriteLine("Default month : ");
            }
            finally
            {
                Console.WriteLine(cal[ind]);
            }

            Console.WriteLine(new string('-',30));

            Console.WriteLine("Enter days:");

            int days = 0;
            try
            {
                days = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a number!");
            }

            cal.FindMonthesByDays(days);

            Console.ReadKey();
        }
    }
}
