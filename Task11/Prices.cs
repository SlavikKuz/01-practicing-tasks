using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
        struct Prices
        {
            string productName;
            string storeName;
            double? price;

            public string ProductName
            {
                get { return productName; }
            }

            public string StoreName
            {
                get { return storeName; }
            }

            public double? Price
            {
                get { return price; }
            }

            public Prices(string storeName, string productName, double? price)
            {
                this.storeName = storeName;
                this.productName = productName;
                this.price = price;
            }
    }
}
