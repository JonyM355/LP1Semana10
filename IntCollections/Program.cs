using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace IntCollections
{
    public class Program
    {
        private static void Main()
        {
            int[] nums = {1, 10, -30, 10, -5};


            //  List
            List<int> list = new List<int>();
            foreach (int num in nums)
            {
                list.Add(num);
            }
            Console.WriteLine("List: " + string.Join(", ", list));


            //  Stack
            Stack<int> stck = new Stack<int>();
            foreach (int num in nums)
            {
                stck.Push(num);
            }
            Console.WriteLine("Stack: " + string.Join(", ", stck));


            //  Queue
            Queue<int> queue = new Queue<int>();
            foreach (int num in nums)
            {
                queue.Enqueue(num);
            }
            Console.WriteLine("Queue: " + string.Join(", ", queue));


            //  HashSet
            HashSet<int> hashS = new HashSet<int>();
            foreach (int num in nums)
            {
                hashS.Add(num);
            }
            Console.WriteLine("HashSet: " + string.Join(", ", hashS));
        }
    }
}
