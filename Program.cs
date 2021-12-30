using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureDemo
{
    public  class Program
    {
        static void Main(string[] args)
        {
            StackUsingLinkedList stack = new StackUsingLinkedList();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.display();
        }
    }
}
