using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var str = Console.ReadLine().ToCharArray();
            var reverse_str = str.Reverse();
            Console.WriteLine(reverse_str.Where((x, i) => x != str[i]).Count()/2);
        }
    }
}
