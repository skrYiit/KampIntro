using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehirler = new MyList<string>();
        }
    }
    class MyList<T> // Generic class
    {
        T[] items;

        public MyList()
        {
            items = new T[10];
        }
        public void Add(T)
        {

        }
    }
}
