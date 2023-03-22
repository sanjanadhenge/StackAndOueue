using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class program
    {
        static void Main(string[] args)
        {
            LinkedListStack stack = new LinkedListStack();
           // stack.Push(70);
           // stack.Push(30);
           // stack.Push(56);
          //  stack.Display();
           // stack.Peek();
          //  stack.Pop();
           // stack.Display();
           LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            queue.Dequeue();
            queue.Display();






        }
    }
}
