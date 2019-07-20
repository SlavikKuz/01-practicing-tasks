using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    abstract class Citizen
    {
        public string Pass { protected set; get; }
        public string FirstName { protected set;  get;  }
        public string LastName { protected set; get; }
        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }


    }
}
