using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input_num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var num_bill = input_num[0];
            var receive_cash = input_num[1];
            var findCombination = new List<int[]>();

            for(int num_10000yen = 0; num_10000yen <= num_bill; num_10000yen++)
            {
                for(int num_5000yen = 0; num_5000yen <= num_bill ; num_5000yen++)
                {
                    var num_1000yen = num_bill - num_10000yen - num_5000yen > 0 ? num_bill - num_10000yen - num_5000yen :0;
                    if ((10000*num_10000yen) + (5000*num_5000yen) + (1000*num_1000yen) == receive_cash && (num_10000yen+num_5000yen+num_1000yen)==num_bill)
                    {
                        int[] tmp = { num_10000yen, num_5000yen, num_1000yen };
                        findCombination.Add(tmp);
                    }
                    
                }
            }
            Console.WriteLine(findCombination.Count == 0 ? "-1 -1 -1" : string.Join(" ", findCombination[0]));

        }
    }
}
