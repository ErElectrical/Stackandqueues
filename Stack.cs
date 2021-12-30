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
        // Utility function to check if
        // the stack is empty or not
        public bool isEmpty()
        {
            return top == null;
        }
        // Utility function to return
        // top element in a stack
        public int peek()
        {
            // check for empty stack
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

        // Utility function to pop top element from the stack
        public void pop() // remove at the beginning
        {
            // check for stack underflow
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                while(! isEmpty())
                {
                    top = (top).link;
                    Console.WriteLine("popped item is ", top);

                }
            }
            
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