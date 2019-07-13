using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class MyDate
    {
        readonly DateTime date;

        public MyDate(DateTime date)
        {
            this.date = date;
        }

        public static MyDate operator - (MyDate d1, MyDate d2)
        {
            TimeSpan timeSpan = d1.date - d2.date;
            DateTime newDate = d1.date.AddDays(timeSpan.Days);
            return new MyDate(newDate);
        }

        public static MyDate operator +(MyDate d1, MyDate d2)
        {
            TimeSpan timeSpan = d1.date - d2.date;
            DateTime newDate = d1.date.AddDays(-timeSpan.Days);
            return new MyDate(newDate);
        }

        public override string ToString()
        {
            return "Date: " + date;
        }

        public static MyDate Sub(MyDate d1, MyDate d2)
        {
            return d1 - d2;
        }

        public static MyDate Add(MyDate d1, MyDate d2) 
        {
            return d1 + d2;
        }

    }
}
