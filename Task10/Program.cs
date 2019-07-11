using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new MyDictionary<string, string>(3);

            dictionary.Add(0, "bord", "table");
            dictionary.Add(1, "eple", "aplle");
            dictionary.Add(2, "sol", "sun");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Second line in the dictionary:");
            Console.WriteLine(dictionary[1]);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Size:");
            Console.WriteLine(dictionary.Length + " words");
            Console.WriteLine(new string('-', 50));

            Console.ReadKey();

        }
    }
}
