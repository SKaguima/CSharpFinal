using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC390_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = { 1, 2, 3 };
            //Console.WriteLine(arr[5]);
            try
            {
                //ThrowExcp();
                int[] arr = { 1, 2, 3 };
                Console.WriteLine(arr[5]);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


            Student myStudend = new Student();
            Cat myCat = new Cat();

            TestME(myCat);
            TestME(myStudend);
        }


        static void ThrowExcp()
        {
            throw new IndexOutOfRangeException("IndexOutOfRangeException was thrown inside MSSA course");
        }



        static void TestME(IGivesHello instance)
        {
            instance.SayHello();
        }

        interface IGivesHello
        {
            void SayHello();
        }

        class Student: IGivesHello
        {
            public string Name { get; set; }

            public void SayHello()
            {
                Console.WriteLine("Hello, my name is: {0}", Name);
            }
        }

        class Cat: IGivesHello
        {
            public int NumLegs { get; set; }

            public void SayHello()
            {
                Console.WriteLine("Meow with {0} legs", NumLegs);
            }
        }
    }
}
