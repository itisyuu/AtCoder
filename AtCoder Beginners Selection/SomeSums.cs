using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(i=>int.Parse(i)).ToArray();
            var result = new List<int>();
            for(int i = 1; i <= input[0]; i++)
            {
                var sum = 0;
                var temp = i;
                while (temp > 0)
                {
                    sum = sum + (temp % 10);
                    temp /= 10;
                }
                if (sum >= input[1] & sum <= input[2]) { result.Add(i); }
            }
            Console.WriteLine($"{result.Sum()}");
        }
    }
}
