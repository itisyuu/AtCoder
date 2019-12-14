using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Sum() > 21 ? "bust" : "win");
            
        }
    }
}
