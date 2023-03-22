using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is pushed to stack", value);
        }
        internal void Display()
        {
            Node temp= this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("stack is Empty");
                return;
            }
            Console.WriteLine("{0} is in the TOP of the stack",this.top);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is Empty");
                return;
            }
            Console.WriteLine("Value popped is {0}", this.top.data);
            this.top = this.top.next;
        }
    }
}
