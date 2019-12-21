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
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = input[0];
            var B = input[1];
            var X = input[2];
            
            Searh(0, (long)1e9, A, B, X);
        }

        public static long Ketanum(long num)
        {
            return (long)Math.Log10(num) + 1;
        }
        public static void Searh(long left, long right,long A, long B,long X)
        {
            if(Math.Abs(right-left)<=1)
            {
                if (X >= (A * right) + (B * Ketanum(right))) { Console.WriteLine(right); }
                else { Console.Write(left); }
            }
            else
            {
                var N = (left + right) / 2;
                if((X == (A * N) + (B * Ketanum(N)))){ Console.WriteLine(N); }
                else {
                    if (X > (A * N) + (B * Ketanum(N))) { Searh(N, right, A, B, X); }
                    else { Searh(left, N - 1, A, B, X); }
                }
                
            }
        }
        
    }
}
