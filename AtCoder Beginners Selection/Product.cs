using System;
using System.Linq;


namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).Aggregate((now, next) => now * next);
            Console.WriteLine("{0}", num % 2 == 0 ? "Even" : "Odd");
        }

    }

}
