using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    //時間制限
    public class Program
    {
        static readonly string[] moji = {"dream","dreamer","erase","eraser" };
        public static void Main(string[] args)
        {
            var input_string = Console.ReadLine().ToArray();
            if (input_string.Length < 4)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine(Judge(input_string) ? "YES" : "NO");
            }
        }

        static char[] Erase(int num,char[] str)
        {
            return str.Skip(num).ToArray();
        }

        static bool Judge(char[] str)
        {
            if(str.Length == 0)
            {
                return true;
            }
            
            if (JudgeChr(5,str))
            {
                if(Judge(Erase(5, str))) { return true; }
            }
            if (JudgeChr(6,str))
            {
                if (Judge(Erase(6, str))) { return true; }
            }
            if (JudgeChr(7,str))
            {
                if(Judge(Erase(7, str))){ return true; }
            }
            return false;
        }
        static bool JudgeChr(int num,char[] str)
        {

            if (moji.Any(i => i == string.Join("", str.Take(num))))
            {
                return true;
            }
            return false;
        }
       
    }
}
