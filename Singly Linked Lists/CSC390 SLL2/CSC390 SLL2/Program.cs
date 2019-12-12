using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC390_SLL2
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList mylist = new SinglyLinkedList();

            mylist.AddFront(1);
            mylist.AddFront(2);
            mylist.AddFront(3);
            mylist.AddFront(4);
            mylist.AddFront(5);
            Console.WriteLine("Printing the list");
            Console.WriteLine(mylist);

            mylist.Reverse2();
            Console.WriteLine("Printing the list");
            Console.WriteLine(mylist);

            mylist.Reverse2();
            Console.WriteLine("Printing the list");
            Console.WriteLine(mylist);
        }
    }

    class Node
    {
        //data
        public int value;
        public Node next;

        //ctor
        public Node(int someValue)
        {
            value = someValue;
        }
    }

    class SinglyLinkedList
    {
        //data
        Node head;

        //methods
        public override string ToString()
        {
            string returnedResult = "";
            Node finger = head;

            while(finger!=null)
            {
                returnedResult = returnedResult + " " + finger.value;
                finger = finger.next;
            }

            return returnedResult;
        }

        public void AddFront(int someValue)
        {
            //create a new node
            Node newNode = new Node(someValue);

            //link the node (point to the head)
            newNode.next = head;

            //move the head
            head = newNode;
        }

        public void Reverse()
        {
            Node finger = head;
            head = null;
            while(finger!=null)
            {
                AddFront(finger.value);
                finger = finger.next;
            }
        }


        public void Reverse2()
        {
            if (head == null || head.next == null)
                return;//nothing to do if the list contains no nodes, or exactly one node
            else
            {
                Node finger = head.next;
                Node finger2 = finger.next;

                head.next = null;

                while (true) 
                {
                    finger.next = head;
                    head = finger;

                    finger = finger2;
                    if (finger2 != null)
                        finger2 = finger2.next;
                    else
                        break;
                } 
            }
        }
    }
}
