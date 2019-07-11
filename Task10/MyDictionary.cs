using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class MyDictionary<Tkey, Tvalue>:IEnumerable<object>, IEnumerator<object>
    {
        readonly Tkey[] tKey;
        readonly Tvalue[] tValue;
        readonly int length;

        int position = -1;

        public MyDictionary(int n)
        {
            tKey = new Tkey[n];
            tValue = new Tvalue[n];
            length = n;
        }

        public void Add(int i, Tkey a, Tvalue b)
        {
            tKey[i] = a;
            tValue[i] = b;
        }

        public int Length
        {
            get { return length; }
        }

        public object Current
        {
            get { return tKey[position] + " " + tValue[position]; }
        }

        object IEnumerator.Current
        {
            get { return tKey[position] + " " + tValue[position]; }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index <= tKey.Length)
                    return "Key: " + tKey[index].ToString() + ". Value: " + tValue[index].ToString() + ".";
                return "Request is outside of boundaries!";
            }
        }

        IEnumerator<object> IEnumerable<object>.GetEnumerator()
        {
            return this;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            Reset();
        }

        public void Reset()
        {
            position = -1;
        }

        public bool MoveNext()
        {
            if (position < tKey.Length-1)
            {
                position++;
                return true;
            }
            return false;
        }
    }
}
