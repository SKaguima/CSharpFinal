using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC390_interfaces_and_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>();
            Console.WriteLine(mylist.Count);
            Console.WriteLine(mylist.Capacity);

            mylist.Add(1);
            Console.WriteLine(mylist.Count);
            Console.WriteLine(mylist.Capacity);


            mylist.Add(2);
            Console.WriteLine(mylist.Count);
            Console.WriteLine(mylist.Capacity);


            mylist.Add(3);
            Console.WriteLine(mylist.Count);
            Console.WriteLine(mylist.Capacity);

            mylist.Add(4);
            Console.WriteLine(mylist.Count);
            Console.WriteLine(mylist.Capacity);

            mylist.Add(5);
            Console.WriteLine(mylist.Count);
            Console.WriteLine(mylist.Capacity);

            Console.WriteLine();
            foreach(var value in mylist.values)
                Console.Write(value+" ");
            Console.WriteLine();



            MyList<Student> myStudentList = new MyList<Student>();
            Console.WriteLine(myStudentList.Count);
            Console.WriteLine(myStudentList.Capacity);

            myStudentList.Add(new Student("Alice", "Brooks", 2.0, 74));
            Console.WriteLine(myStudentList.Count);
            Console.WriteLine(myStudentList.Capacity);


            myStudentList.Add(new Student("Charlie", "Smith", 2.0, 74));
            Console.WriteLine(myStudentList.Count);
            Console.WriteLine(myStudentList.Capacity);


            Console.WriteLine();
            foreach (var value in myStudentList.values)
                Console.WriteLine(value + " ");
            Console.WriteLine();
            //List<int> mylist = new List<int>();
            //mylist.Add(1);
            //mylist.Add(7);
            //mylist.Add(5);
            //mylist.Add(4);
            //mylist.Add(10);
            //mylist.Add(3);

            //mylist.Sort();

            //foreach(int num in mylist)
            //    Console.WriteLine(num);







            //List<Student> mylist = new List<Student>();
            //mylist.Add(new Student("Jill", "Smith", 2.0, 34));
            //mylist.Add(new Student("Bill", "Smith", 2.1, 35));
            //mylist.Add(new Student("Steve", "Azure", 4.0, 36));
            //mylist.Add(new Student("Bill", "Gates", 3.5, 12));


            //mylist.Sort();

            //foreach (Student num in mylist)
            //    Console.WriteLine(num);
            ////num.PrintStudent();

            //Student st10 = new Student("Bill", "Gates", 3.5, 12);
            //FancyMethod(st10);
            //FancyMethod(10);

            Console.WriteLine("foreach ...on my list");
            foreach(var st in myStudentList)
                Console.WriteLine(st);

            Console.WriteLine(myStudentList[0]);
            Console.WriteLine(myStudentList[1]);
        }


       public static void FancyMethod(IComparable obj)
        {
            Console.WriteLine("Fancy method ...");
            Console.WriteLine(obj);
        }
    }

    class Student : IComparable
    {
        //data
        string firstName;
        string lastName;
        double GPA;
        int ID;



        //methods
        public void PrintStudent()
        {
            Console.WriteLine("Last Name = {0}\tFirst Name = {1}\tGPA={2}, ID={3}", lastName, firstName, GPA, ID);
        }

        public override string ToString()
        {
            return String.Format("Last Name = {0}\tFirst Name = {1}\tGPA={2,-6} ID={3}", lastName, firstName, GPA, ID);
        }

        public int CompareTo(object obj)
        {
            //compare this (current object) with obj (the second object)
            Student st1 = this;
            Student st2 = (Student)obj;
            // return st1.lastName.CompareTo(st2.lastName);
            //return st1.ID - st2.ID;

            //if (st1.GPA < st2.GPA)
            //    return -1;
            //else if(st1.GPA > st2.GPA)
            //    return 1;
            //else return 0;
            return st1.GPA.CompareTo(st2.GPA);
        }

        //ctor
        public Student(string fn, string ln, double gp, int id)
        {
            firstName = fn;
            lastName = ln;
            GPA = gp;
            ID = id;
        }
    }

    class MyList<T> : IEnumerable, IEnumerable<T>
    {
        //data
        public T[] values;
        public int Count { get; private set; }
        public int Capacity { get; private set; }
        //methods
        public T this[int id]
        {
            get { return values[id]; }
            set { values[id] = value; }
        }

        public void Add(T newVal)
        {
            if(Capacity==0) //if the array is empty
            {
                values = new T[4];
                Capacity = 4;
            }
            else if(Count==Capacity) //the array is full
            {
                T[] oldValues = values;
                values = new T[2 * Capacity]; //resizing/doubling the array
                Capacity = 2 * Capacity;

                for (int i = 0; i < Count; i++)//copy old array into new array
                    values[i] = oldValues[i];

            }

            values[Count] = newVal;
            Count++;
        }



        public IEnumerator GetEnumerator()
        {
            foreach (var x in values)
                yield return x;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            foreach (var x in values)
                yield return x;
        }



        //ctor
        public MyList()
        {
            Count = 0;
            Capacity = 0;
            values = null;
        }
    }
}
