using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Stores database = new Stores();

            for (int a=0; a<2; a++)
            {
                Console.WriteLine(database[a]);
            }

            Console.WriteLine("Enter store to see:");

            int option = 0;
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not a store!");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Result for the first store:");
            }

            Console.Write(database[option]);

            Console.ReadKey();

        }
    }
}
