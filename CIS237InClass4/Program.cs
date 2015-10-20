using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS237InClass4
{
    class Program
    {
        static void Main(string[] args)
        {
            //define a new linked list to use
            MyLinkedList myLinkedList = new MyLinkedList();

            //add a bunch of stuff to it
            myLinkedList.Add("first");
            myLinkedList.Add("second");
            myLinkedList.Add("third");
            myLinkedList.Add("fourth");

            //loop through with this differently looking for loop to output
            //in here, the first part is initalization: setting x to the Head
            //the second part is the test: if x != null, keep going
            //the last part is : set the current x to x's next pointer.(The next in the list)
            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }
            //couple of blank lines
            Console.WriteLine();
            Console.WriteLine();

            //Print out the 2nd One
            Node nodeINeed = myLinkedList.Retrive(2);
            Console.WriteLine(nodeINeed.Data);
            Console.WriteLine("\n");

            //Same as above
            //Print out the 2nd one again in one statment
            Console.WriteLine(myLinkedList.Retrive(2).Data);
            Console.WriteLine("\n");

            //delete the 2nd element in the list
            myLinkedList.Delete(2);

            //delete the new 2nd element in the list which was 3rd before previous delete
            myLinkedList.Delete(2);


            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
                
            }

            //couple of blank lines
            Console.WriteLine();
            Console.WriteLine();

            //Add two new ones to the list
            myLinkedList.Add("fifith");
            myLinkedList.Add("sixth");


            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

            Console.WriteLine("*******************************");
            Console.WriteLine("*******************************");



            //A generic linked list that sends in the type that we would like to use
            //This one will behave exactly like the one used above since it is taking a string.

            GenericLinkedList<string> myGenericLinkedList = new GenericLinkedList<string>();

            //Some other linked lists that can use the generic one. ONe of them is of type integer, 
            //and the other one is type object
            GenericLinkedList<int> myOtherGenericLinkedList = new GenericLinkedList<int>();

            GenericLinkedList<object> myObjectGenericLinkedList = new GenericLinkedList<object>();


            //Use the generic string one to do the same work as above

            //add a bunch of stuff to it
            myGenericLinkedList.Add("first_myGenericLinkedList");
            myGenericLinkedList.Add("second_myGenericLinkedList");
            myGenericLinkedList.Add("third_myGenericLinkedList");
            myGenericLinkedList.Add("fourth_myGenericLinkedList");

            //loop through with this differently looking for loop to output
            //in here, the first part is initalization: setting x to the Head
            //the second part is the test: if x != null, keep going
            //the last part is : set the current x to x's next pointer.(The next in the list)
            for (GenericNode<string> x = myGenericLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }



        }



    }
}
