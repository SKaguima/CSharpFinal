using System;
using System.Data;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMidTermProject
{

    //The System.Collections namespace contains interfaces and classes that define various collections of objects, such as lists, queues, bit arrays, hash tables and dictionaries.
    //The System namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, 
    //and processing exceptions.
    //System.Data namespace provides access to classes that represent the ADO.NET architecture. ADO.NET lets you build components that efficiently manage data from multiple data sources.

    public class Enqueue : DataColumn
    {
        public static void Main()
        {
            //(((System.Collections)))
            //Enqueue Method: Adds and object to the end of the Queue
            //Dequeue Method: Removes and returns the object at the beginning of the Queue
            //PrintValues Method: Widening conversion that can allow for any possible value of the original data
            //.Count Method: Gets the number of elements contained in a Queue
            //Peek Method: Returns the object at the beginning of the queue but does not remove it

               
            // Creating and initializing a new Queue.
            Queue myQue = new Queue();
            myQue.Enqueue("My");
            myQue.Enqueue("Midterm");
            myQue.Enqueue("Project");
            myQue.Enqueue("C#");


            /* 
            This code produces the following output.

            myQue
            Count:    4
            Values:    My    Midterm    Project     C#  
            */

            Console.WriteLine("The Peek Method returns the first object of the Queue");
            Console.WriteLine("(Peek)   \t{0}", myQue.Peek());
            Console.Write("myQue");
            Console.WriteLine("\tCount:    {0}", myQue.Count);
            Console.Write("\tValues:");
            PrintValues(myQue);



            //(((System.Data)))
            //.Create Instance: Creates a 3 - dimensional array of the specified type and length with zero based indexing
            //.GetLowerBound: Gets the Index of the last element in the array
            //.GetUpperBound: Gets the Index of the last element in the array
            //SetValue: Set a value to the specified position in the array
            //.Rank: Gets the rank(number of the dimensions of the array


            // Creating and initializing a new three-dimensional Array of type Int32.
            Array myArr = Array.CreateInstance(typeof(Int32), 2, 3, 4);
            for (int i = myArr.GetLowerBound(0); i <= myArr.GetUpperBound(0); i++)
            {
                for (int j = myArr.GetLowerBound(1); j <= myArr.GetUpperBound(1); j++)
                {
                    for (int k = myArr.GetLowerBound(2); k <= myArr.GetUpperBound(2); k++)
                    {
                        myArr.SetValue((i * 100) + (j * 10) + k, i, j, k);
                    }
                }
            }

            // Displays the properties of the Array.
            Console.WriteLine("The Array has {0} dimension(s) and a total of {1} elements.", myArr.Rank, myArr.Length);
            Console.WriteLine("\tLength\tLower\tUpper");
            for (int i = 0; i < myArr.Rank; i++)
            {
                Console.Write("{0}:\t{1}", i, myArr.GetLength(i));
                Console.WriteLine("\t{0}\t{1}", myArr.GetLowerBound(i), myArr.GetUpperBound(i));
            }

            // Displays the contents of the Array.
            Console.WriteLine("The Array contains the following values:");
            PrintValues(myArr);


            DataColumn myDataCol = new DataColumn();
            myDataCol.MakeTable();
            //myDataCol.

        }

        public static void PrintValues(Array myArr)
        {
            System.Collections.IEnumerator myEnumerator = myArr.GetEnumerator();
            int i = 0;
            int cols = myArr.GetLength(myArr.Rank - 1);
            while (myEnumerator.MoveNext())
            {
                if (i < cols)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine();
                    i = 1;
                }
                Console.Write("\t{0}", myEnumerator.Current);
            }
            Console.WriteLine();
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
            Console.ReadLine();
        }

    }


    public class DataColumn
    {

        //(((System.Data)))
        //.HasErrors: Gets a value, indicates whether there is an error
        //MakeTable: Used to make a table
        //GetType: Gets the type with the specified name, and performs a case-sensitive search
        //new : Initializes a new instance of an object, in this a table
        //.Add: Adds a data row to the datarow collection object

        public Type DataType;
        public bool AllowDBNull;
        public string Caption;
        public string ColumnName;
        public int DefaultValue;

        public void MakeTable()
        {
            // Create a DataTable. 
            DataTable table = new DataTable("Product");

            // Create a DataColumn and set various properties. 
            DataColumn column = new DataColumn
            {
                DataType = System.Type.GetType("System.Decimal"),
                AllowDBNull = false,
                Caption = "Price",
                ColumnName = "Price",
                DefaultValue = 25
            };

            // Add 10 rows and set values. 
            DataRow row;// = new DataRow();
            for (int i = 0; i < 10; i++)
            {
                row = table.NewRow();
                row["Price"] = i + 1;

                // Be sure to add the new row to the 
                // DataRowCollection. 
                table.Rows.Add(row);
                Console.WriteLine();
                Console.ReadLine();
            }
        }
        private bool Reconcile(DataTable thisTable)
        {
            foreach (DataRow row in thisTable.Rows)
            {
                //Insert code to try to reconcile error.

                // If there are still errors return immediately
                // since the caller rejects all changes upon error.
                if (row.HasErrors)
                    return false;
            }
            return true;
        }
    }

    class MyArray
    {
            

        public static void PrintValues(Array myArr)
        {
            System.Collections.IEnumerator myEnumerator = myArr.GetEnumerator();
            int i = 0;
            int cols = myArr.GetLength(myArr.Rank - 1);
            while (myEnumerator.MoveNext())
            {
                if (i < cols)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine();
                    i = 1;
                }
                Console.Write("\t{0}", myEnumerator.Current);
            }
            Console.WriteLine();
        }
    }
    /* 
    This code produces the following output.


    Length    Lower    Upper
    0:    2    0    1
    1:    3    0    2
    2:    4    0    3

    The Array contains the following values:
    0    1    2    3
    10    11    12    13
    20    21    22    23
    100    101    102    103
    110    111    112    113
    120    121    122    123
    */

  

}




