using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car("Tesla", "110", 2016, "Blue"));
            cars.Add(new Car("Volvo", "A02", 2010, "White"));
            cars.Add(new Car("Audi", "A8", 2018, "Red"));
            cars.Add(new Car("Honda", "RX", 2012, "Blue"));

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer("110", "John Doe", "123-123-123"));
            customers.Add(new Customer("A8", "John Doe", "123-123-123"));
            customers.Add(new Customer("RX", "Mike Meyers", "321-321-321"));

            var query = from car in cars
                        join cust in customers
                        on car.Model equals cust.Model
                        select new
                        {
                            name = cust.Name,
                            cell = cust.CellPhone,
                            make = car.CarMake,
                            year = car.Year,
                            colr = car.Color
                        };

            foreach (var q in query)
            {
                Console.WriteLine(q.name + " " + q.cell + " " + q.make + " " + q.year + " " + q.colr);
            }

            Console.ReadKey();
        }
    }
}
