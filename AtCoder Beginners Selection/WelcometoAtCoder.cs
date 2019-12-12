using System;
using System.Linq;

namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).Sum();
            string s = Console.ReadLine();
            Console.WriteLine($"{firstNum + numbers} {s}");
        }

    }

}
