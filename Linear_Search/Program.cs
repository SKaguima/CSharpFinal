using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC340_515_Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vals = { 13, 29, 27, 4, 8, 51 };
            LinearSearch(vals, 29);
        }
        
        public static int LinearSearch(int[] values, int key)
        {
            //traverse the array
            for (int pos = 0; pos < values.Length; pos++)
            {
                //checl if current value in the array is the same as the key
                if (values[pos] == key)
                    return pos;
            }
            // you only get here if you could not find the key
            return -1;

        }
    }
}
