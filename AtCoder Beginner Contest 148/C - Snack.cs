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
            var input_num = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Console.WriteLine(Lcm(input_num[0], input_num[1]));
        }
        static long Gcd(long a, long b)
        {
            var v = new[] { a, b };
            while (v[1] != 0) { v = new[] { v[1], v[0] % v[1] }; }
            return v[0];
        }

        static long Lcm(long a, long b)
        {
            return a / Gcd(a, b) * b;
        }
    }

}
