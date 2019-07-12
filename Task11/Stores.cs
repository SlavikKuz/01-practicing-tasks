using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Stores
    {
        Prices[] stores;

        public Stores()
        {
            stores = new Prices[2];

            for (int i=0; i<stores.Length; i++)
            {
                string name;
                Console.WriteLine("Enter store: ");
                name = Console.ReadLine();

                string prod;
                Console.WriteLine("Enter product: ");
                prod = Console.ReadLine();

                double? price;
                Console.WriteLine("Enter price: ");
                try
                {
                    price = Convert.ToDouble(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Wrong price!");
                    Console.WriteLine(e.Message);
                    price = null;
                }
                stores[i] = new Prices(name, prod, price);
            }
            stores = stores.OrderBy(products => products.StoreName).ToArray<Prices>();
        }

        public string Show(Prices a)
        {
           return a.ProductName + ": " + a.Price;
        }

        public string this[int index]
        {
            get
            {
                try
                {
                    return Show(stores[index]);
                }
                catch (Exception e)
                {
                    Console.WriteLine("out of range!");
                    Console.WriteLine(e.Message);
                    return "";
                }
            }
        }
    }
}
