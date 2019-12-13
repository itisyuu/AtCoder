using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var input = new List<int[]>();
            bool canGo = false;
            input.Add(new int[]{ 0, 0, 0 });
            for(int i=0; i < N; i++)
            {
                var tmp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                input.Add(tmp);
            }

            for(int i = 0; i < input.Count - 1; i++)
            {
                var time_distance = input[i+1][0]-input[i][0];
                var map_distance = Math.Abs(input[i + 1][1] - input[i][1]) + Math.Abs(input[i + 1][2] - input[i][2]);
                if(time_distance - map_distance >= 0)
                {
                    //奇数距離かつ奇数時間か偶数時間かつ偶数距離
                    if ((time_distance % 2 == 1 && map_distance %2 ==1) || (time_distance % 2 == 0 && map_distance % 2 == 0))
                    {
                        canGo = true;
                    }
                    else { canGo = false; }
                }
                else { canGo = false; }
            }
            Console.WriteLine("{0}", canGo ? "Yes" : "No");
        }
    }
}
