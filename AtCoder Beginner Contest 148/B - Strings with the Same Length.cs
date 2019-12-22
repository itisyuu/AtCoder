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
            var input_string = Console.ReadLine().Split();
            for(int i = 0; i < input_string[0].Length; i++)
            {
                Console.Write(input_string[0][i]);
                Console.Write(input_string[1][i]);
            }
        }
        
    }
}
