using System;
using System.Linq;


namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var input = Console.ReadLine().Split().Select(i => int.Parse(i));
            var count = 0;

            while(input.Count(i=> i%2 == 0).ToString()  == num)
            {
                count++;
                input = input.Select(i => i/2);
            }
            Console.Write($"{count}");
        }

    }
}
