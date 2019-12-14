using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //解けなかったやつ
            var num_people = int.Parse(Console.ReadLine());
            int[,] input_evidence = new int[num_people, num_people];
            for(int i = 0; i < num_people; i++)
            {
                for(int j= 0; j < num_people; j++) { input_evidence[i, j] = -1; }
            }
            int count = 0;
            for(int i = 0; i < num_people; i++)
            {
                var num_evidence = int.Parse(Console.ReadLine());
                for(int j=0; j < num_evidence; j++)
                {
                    var evidence = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    input_evidence[i, evidence[0]-1] = evidence[1];
                }
            }
            for(int i = 0; i < num_people; i++)
            {
                for(int j = 0; j < num_people; j++)
                {
                    if(input_evidence[i,j] != -1)
                    {
                        if (input_evidence[i, j] == input_evidence[j, i]) { count++; }
                    }
                }
            }
            Console.WriteLine(count == 0 ? 0 : num_people - (count)/2);
        }
    }
}
