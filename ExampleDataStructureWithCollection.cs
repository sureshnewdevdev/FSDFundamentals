using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    public class ExampleDataStructureWithCollection
    {
        public void Workout()
        {
            Stack stack1 = new Stack();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);


            object value=stack1.Pop();
            
            
            Console.WriteLine(value);


            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            value = queue.Dequeue();
            Console.WriteLine(value);


        }
    }
}
