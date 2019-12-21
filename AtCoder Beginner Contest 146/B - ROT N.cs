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
            string MOJI = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var N = int.Parse(Console.ReadLine());
            var inputString = Console.ReadLine().ToArray(); ;
            for(int i = 0; i < inputString.Length; i++)
            {
                var num = MOJI.IndexOf(inputString[i]);
                Console.Write(MOJI[num + N < 26 ? num + N : num + N - 26]);
            }
        }
    }
}
