using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Launch(-10);

            Hanoi(1, 'A', 'C', 'B');

            Console.WriteLine(   IsEven(78)  );
            
        }

        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }

        public static void Hanoi(int n, char from, char to, char intermediary)
        {
            if (n > 0)
            { 
                Hanoi(n - 1, from, intermediary, to);
                Console.WriteLine(from + " -> " + to);
                Hanoi(n - 1, intermediary, to, from);
            }
        }


        static void Launch(int num)
        {
            if (num > 0)
            {
                Console.WriteLine(num);
                Launch(num - 1);
            }
            else //base case
            {
                Console.WriteLine("Blastoff");
            }
        }
    }
}
