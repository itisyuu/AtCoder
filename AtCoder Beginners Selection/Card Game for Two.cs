using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var input_num = Console.ReadLine().Split()
                .Select(i => int.Parse(i))
                .OrderBy(i=>i);
            Stack<int> numbers = new Stack<int>();
            var A = new List<int>();
            var B = new List<int>();
            foreach(int i in input_num)
            {
                numbers.Push(i);
            }
            while (numbers.Count > 0)
            {
                A.Add(numbers.Pop());
                if(numbers.Count != 0)
                    B.Add(numbers.Pop());
            }
            Console.WriteLine($"{A.Sum()-B.Sum()}");

        }
    }
}
