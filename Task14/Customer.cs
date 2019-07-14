using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Customer
    {
        readonly string model;
        readonly string name;
        readonly string cellPhone;

        public Customer(string model, string name, string phone)
        {
            this.model = model;
            this.name = name;
            this.cellPhone = phone;
        }

        public string Model
        { get { return model; } }

        public string Name
        { get { return name; } }

        public string CellPhone
        { get { return cellPhone; } }
    }
}
