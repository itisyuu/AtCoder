using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace AtCoder
{
    enum Week
    {
        SAT = 1,
        FRI,
        THU,
        WED,
        TUE,
        MON,
        SUN
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            foreach (Week w in typeof(Week).GetEnumValues())
            {
                string day = Enum.GetName(typeof(Week), w);
                if (input == day) { Console.WriteLine((int)w); }
            }
        }
    }
}
