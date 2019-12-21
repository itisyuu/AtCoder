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
            //サンプルは合ったけど他は合わない・・・
            var N = long.Parse(Console.ReadLine());
            var input = new List<long[]>();
            var referenced_num = new long[N+1];
            var map = new long[N+1, N+1];
            for(long i = 0; i < N - 1; i++)
            {
                var tmp = Console.ReadLine().Split().Select(long.Parse).ToArray();
                referenced_num[tmp[0]] += 1;
                referenced_num[tmp[1]] += 1;
                input.Add(tmp);
            }
            
            Console.WriteLine(referenced_num.Max());
            foreach(long[] x in input)
            {

                var vacant = DecisionNumberToMap(ConvertHairetsu(map,x[0]), referenced_num.Max());
                map[x[0], x[1]] = vacant;
                map[x[1], x[0]] = vacant;
            }
            for(long i = 1; i <= N; i++)
            {
                for(long j = 1; j <= i - 1; j++) {if(map[i, j] != 0) Console.WriteLine(map[i, j]); }
            }
        }
        public static long DecisionNumberToMap(long[] x,long referenced_maxnum)
        {
            var rec = new long[referenced_maxnum + 1];
            foreach(long num in x)
            {
                rec[num] = 1;
            }
            for(long i = 1; i <= referenced_maxnum; i++)
            {
                if(rec[i] == 0)
                {
                    return (i);
                }
            }
            return (0);
        }
        public static long[] ConvertHairetsu(long[,] x,long num)
        {
            long[] returns = new long[(long)Math.Sqrt(x.Length)];
            for(long i = 0; i < (long)Math.Sqrt(x.Length); i++)
            {
                returns[i] = x[num, i];
            }
            return returns;
        }
        
    }
}
