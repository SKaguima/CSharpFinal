using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC390_data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            Console.WriteLine("count = {0}", mylist.Count);
            Console.WriteLine("Capacity = {0}", mylist.Capacity);

            mylist.Add(5);
            Console.WriteLine("count = {0}", mylist.Count);
            Console.WriteLine("Capacity = {0}", mylist.Capacity);

            mylist.Add(2);
            Console.WriteLine("count = {0}", mylist.Count);
            Console.WriteLine("Capacity = {0}", mylist.Capacity);


            mylist.Add(73);
            mylist.Add(17);
            Console.WriteLine("count = {0}", mylist.Count);
            Console.WriteLine("Capacity = {0}", mylist.Capacity);

            mylist.Add(42);
            Console.WriteLine("count = {0}", mylist.Count);
            Console.WriteLine("Capacity = {0}", mylist.Capacity);

            Console.WriteLine(mylist.GetHashCode());
            double x = -7.5;
            double y = 7.5;
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(y.GetHashCode());
        }
    }
}
