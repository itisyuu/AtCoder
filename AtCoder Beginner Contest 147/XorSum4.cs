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
            
            var N = Console.ReadLine().Split().Select(int.Parse);
            IEnumerable<long> input_number = Console.ReadLine().Split().Select(long.Parse);
            long sum = 0;
            for(int i = 0; i < 64; i++)
            {
                var numOf1 = 0;
                var numOf0 = 0;
                foreach(long num in input_number)
                {
                    var bit = (num >> i)&1;
                    if(bit == 1){numOf1 += 1;}
                    else { numOf0 += 1; }
                }
                
                long tmp = (1 << i) % 1000000007;
                long tm1 = (numOf0 % 1000000007 * numOf1 % 1000000007);
                sum  += (tmp % 1000000007 * tm1 % 1000000007) % 1000000007;
                sum %= 1000000007;
                
            }
            Console.WriteLine(sum);
        }
    }
}
