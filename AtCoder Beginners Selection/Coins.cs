using System;
using System.Linq;

namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var yen_500 = int.Parse(Console.ReadLine());
            var yen_100 = int.Parse(Console.ReadLine());
            var yen_50 = int.Parse(Console.ReadLine());
            var aim = int.Parse(Console.ReadLine());
            var count = 0;

            for(int i = 0; i <= yen_500; i++)
            {           
                for(int j= 0; j <= yen_100; j++)
                {
                    for(int k = 0; k <= yen_50; k++)
                    {
                        if(((500*i)+(100*j)+(50*k)) == aim)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.Write($"{count}");

        }

    }
}
