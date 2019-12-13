using System;
using System.Linq;

namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var num = Console.ReadLine().Count(i=> i == '1');
            Console.WriteLine($"{num}");
        }

    }
}
