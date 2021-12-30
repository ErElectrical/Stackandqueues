using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackUsingLinkedList stack = new StackUsingLinkedList();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            Console.WriteLine("inserted stack is ");
            stack.display();
            int value = stack.peek();
            Console.WriteLine(value);
            stack.pop();
            stack.display();

        }
    }
}