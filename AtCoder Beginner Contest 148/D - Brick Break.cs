using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var input_num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>();
            foreach (int num in input_num.Reverse())
            {
                stack.Push(num);
            }
            var i = 1;
            var count = 0;
            while (stack.Count > 0)
            {
                if(stack.Peek() == i) { count += 1; i += 1; };
                stack.Pop();
            }
            Console.WriteLine(count==0?-1:N-count);
        }

    }

}
