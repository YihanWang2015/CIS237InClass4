using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS237InClass4
{
    class MyLinkedList
    {
        //private variable to hold the current position of where we are in the linked list
        private Node current;


        //A public property that will point to the Head node (the first one in the list)
        public Node Head
        {
            get;

            set;
        }

        //Construtor. It will set the Head to null because there is nothing in the list yet(empty list).
        public MyLinkedList()
        {
            Head = null;
        }

        public void Add(string content)
        {
            //Make a new node to add to the linked list
            Node node = new Node();
            //Set the data to the passed in content
            node.Data = content;

            //This will add the first element to our list

            if (Head == null)
            {
                Head = node;
            }

                //Not the first node, so set the new node to the current node's next variable
            else
            {
                current.Next = node;
            }

            //Move down the list. Set current to the new node we added.
            current = node;

        }


        public bool Delete(int Position)
        {
            
            //Set current to head. need to walk through it from the beginning
            current = Head;

            if (Position == 1)
            {

               

                //Set the Head to the next node in the list
                Head = current.Next;

                //Delete the current.next pointer so there is no reference from current to another node
                current.Next = null;

                //current = null because we want the garbage collector to come pick it up.
                current = null;

                //it was successfull so, return true;
                return true;
            }

            //check to make sure that at least a positive number was entered.
            //Should also check to make sure that the position is less than the size of the array
            //so that we aren't looking for something that doesn't exist. Adding a size property will be more work.
            //TODO: Add a size property
            if (Position > 1)
            {

                //Make a temp node that starts at the Head. This way we don't need to actually
                //move the Head pointer. We can just use the temp node.
                Node tempNode = Head;

                //Set a last node to null. It will be used for the delete
                Node lastNode = null;

                //Start a counter to know if we have reached the position yet or not.
                int count = 0;


                //while the tempNode is NOT null, we can continue to walk though the linked list.
                //If it is null, then we have reached the end.
                while (tempNode != null)
                {
                    //If the count is the same as the position entered -1, then we have found the one 
                    //we would like to delete.
                    if (count == Position - 1)
                    {
                        //Set the last node's next property to the tempnodes next property
                        lastNode.Next = tempNode.Next;
                        //remove the next pointer of the tempnode
                        tempNode.Next = null;
                        //return true because it was successful
                        return true;
                    }

                    //Increment the counter since we are going to move forward in the list
                    count++;

                    //Set the lastNode equal to the tempNode. Now both variables are pointing to the
                    //exact same node.
                    lastNode = tempNode;

                    //Now set the tempNode to tempNodes Next node. This will move tempNode
                    //one more location forward in the list.
                    tempNode = tempNode.Next;
                }
            }

            //tempNode became null, so apparently we did not find it. Return false.
            return false;
        }





    }
}
