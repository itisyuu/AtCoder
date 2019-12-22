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
            var N = long.Parse(Console.ReadLine());
            long sum = 0;
            long i = 1;
            if(N%2 == 0)
            {
                while (true)
                {
                    if (N / (long)Math.Pow(5, i) > 0) { sum += N / (long)Math.Pow(5, i) / 2; }
                    else { break; }
                    i++;
                }
                Console.WriteLine(sum);
            }
            else { Console.WriteLine("0"); }
        }
        
    }

}
