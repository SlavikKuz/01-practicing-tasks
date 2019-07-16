using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Calendar: IEnumerable, IEnumerator
    {
        Month[] calendr;

        public Calendar()
        {
            calendr = new Month[12];

            for (int i=0; i<calendr.Length; i++)
            {
                calendr[i] = new Month(i + 1, i + 1);
                Console.WriteLine(calendr[i].ToString());
            }

        }

        int position = -1;

        public object Current => calendr[position];

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (position < calendr.Length)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public string this[int index]
        {
            get
            {
                if (index > 0 && index <= calendr.Length)
                    return calendr[index - 1].ToString();
                else return "The month does not exist!";
            }
        }

        public void FindMonthesByDays(int days)
        {
            int check = 0;
            for (int i = 0; i<calendr.Length; i++)
            {
                if (calendr[i].FindMonth(days))
                {
                    Console.WriteLine(calendr[i].ToString());
                    check++;
                }
            }

            if (check == 0) Console.WriteLine("The month does not exist!");
        }

    }
}
