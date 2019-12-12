using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stanley's Give-Away");
            Console.Write("Pick 1, 2 or 3: ");
            string userResponse = Console.ReadLine();

            string message = "";

            if (userResponse == "1")
            {
                message = "You've won a Vacation!";                              
            }

            else if (userResponse == "2")
            {
                message = "You've won a motorcycle!";                
            }

            else if (userResponse == "3")
            {
                message = "You've won Dinner for 2!";
            }

            else 
            {
                message = "Invalid Option. Please enter 1, 2, or 3";
                
            }

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
