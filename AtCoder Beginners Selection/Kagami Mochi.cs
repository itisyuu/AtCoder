using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input_num = new List<int>();
            var N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                input_num.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(input_num.Distinct().Count());
        }
    }
}
