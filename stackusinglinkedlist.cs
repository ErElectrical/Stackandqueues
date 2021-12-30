using System;
namespace DatastructureDemo
{
    //// Create Stack Using Linked list

    public class StackUsingLinkedList
    {
        private class Node
        {
            // integer data

            public int data;

            // reference variable Node type


            public Node link;

        }
        Node top;
        // create global top reference variable

        // constructor for our class
        public StackUsingLinkedList()
        {
            this.top = null;

        }
        // Utility function to add
        // an element x in the stack
        // insert at the beginning
        public void push(int x)
        {
            // create new node temp and allocate memory
            Node temp = new Node();

            // check if stack (heap) is full.
            // Then inserting an element
            // would lead to stack overflow
            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }

            // initialize data into temp data field
            temp.data = x;

            // put top reference into temp link
            temp.link = top;

            // update top reference
            top = temp;
        }

        public void display()
        {
            // check for stack underflow
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {

                    // print node data
                    Console.Write("{0}->", temp.data);

                    // assign temp link to temp
                    temp = temp.link;
                }
            }
        }


    }
}
