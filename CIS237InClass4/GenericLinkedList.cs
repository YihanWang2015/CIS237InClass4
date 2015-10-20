using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS237InClass4
{
    class GenericLinkedList<T>
    {


         //private variable to hold the current position of where we are in the linked list
        private GenericNode<T> current;

        //Private variable to hold the last postion of the linked list.
        private GenericNode<T> last;


        //A public property that will point to the Head node (the first one in the list)
        public GenericNode<T> Head
        {
            get;

            set;
        }

        //Construtor. It will set the Head to null because there is nothing in the list yet(empty list).
        public GenericLinkedList()
        {
            Head = null;
        }

        public void Add(T content)
        {
            //Make a new node to add to the linked list
            GenericNode<T> node = new GenericNode<T>();
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
               // current.Next = node; old code
                last.Next = node;
            }

            //Move down the list. Set current to the new node we added.
           // current = node; old code
            last = node;

        }


        public bool Delete(int Position)
        {
            
            //Set current to head. need to walk through it from the beginning
            current = Head;

            if (Position == 1)
            {            

                //Set the Head to the next node in the list. This will be the 2nd one.
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
                GenericNode<T> tempNode = Head;

                //Set a previous tem node to null. It will be used for the delete
                GenericNode<T> previousTempNode = null;

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
                        //Set the last node's Next property to the tempnodes Next property
                        //Jumping over the tempNode. The previous node's next will now point
                        //to the node AFTER the tempNode

                        previousTempNode.Next = tempNode.Next;

                        if (tempNode.Next == null)

                        {
                            last = previousTempNode;
                        }


                        //remove the next pointer of the tempnode
                        tempNode.Next = null;
                        //return true because it was successful
                        return true;
                    }

                    //Increment the counter since we are going to move forward in the list
                    count++;

                    //Set the lastNode equal to the tempNode. Now both variables are pointing to the
                    //exact same node.
                    previousTempNode = tempNode;

                    //Now set the tempNode to tempNodes Next node. This will move tempNode
                    //one more location forward in the list.
                    tempNode = tempNode.Next;
                }
            }

            //tempNode became null, so apparently we did not find it. Return false.
            return false;
        }

        //************************   10/20/2015   ************************************

        public GenericNode<T> Retrive(int Position)
        {
            //Set the temp node to the Head so we are at the start of the list
            GenericNode<T> tempNode = Head;

            //A node that will be used to return the actual node we are looking for.
            GenericNode<T> returnNode = null;

            //Counter to see where we are in the list
            int count = 0;

            //While our tempnode is not at the end of the list
            while (tempNode != null)
            {
                //If the count mataches the postion that we are looking for, we have found it
                if (count == Position - 1)
                {
                    //Set the returnNode var to the tempNode, which is the one we were looking for
                    returnNode = tempNode;  
                    //Break out of the loop. NO need to keep looking.  
                    break;
                }
                //Increase our counter since we haven't found it yet.
                count++;
                //Set the tempNode we are using for walking to the next node in the list
                tempNode = tempNode.Next;

            }
            //return the returnNode
            return returnNode;
        }

    }
}
