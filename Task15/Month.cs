using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    public class Month
    {
        readonly int order;
        readonly string name;
        readonly int days;

        public Month(int order, int name)
        {
            this.order = order;
            this.name = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(name);
            this.days = DateTime.DaysInMonth(DateTime.Now.Year, name);
        }

        public int Order { get { return order; } }
        public string Name { get { return name; } }
        public int Days { get { return days; } }

        public override string ToString()
        {
            return this.Order + " " + this.Name + " " + this.Days;
        }

        public bool FindMonth(int days)
        {
            if (this.days == days)
                return true;

            return false;
        }
    }
}
