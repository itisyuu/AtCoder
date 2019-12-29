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
            var N = Inputer.Int1Char();
            for(int i= N; i <= 1e10; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
        public static bool IsPrime(int num)
        {
            if (num < 2) return false;
            else if (num == 2) return true;
            else if (num % 2 == 0) return false;

            double sqrtNum = Math.Sqrt(num);
            for (int i = 3; i <= sqrtNum; i += 2)
            {
                if (num % i == 0)
                {
                    
                    return false;
                }
            }

            
            return true;
        }


    }

    /// <summary>
    /// 入力受付
    /// </summary>
    static class Inputer
    {
        /// <summary>
        /// A B C の複数整数からなる1行を受け取る
        /// </summary>
        /// <returns></returns>
        public static int[] IntArray1Line()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        /// <summary>
        /// 整数N　のような１つの整数からなる入力を受け取る
        /// </summary>
        /// <returns></returns>
        public static int Int1Char()
        {
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// 大きい整数N　のような１つの整数からなる入力を受け取る
        /// </summary>
        /// <returns></returns>
        public static long Long1Char()
        {
            return long.Parse(Console.ReadLine());

        }

        public static long[] LongArray1Line()
        {
            return Console.ReadLine().Split().Select(long.Parse).ToArray();
        }

    }

    /// <summary>
    /// 順列を出すやつ
    /// </summary>
    /// <typeparam name="T"></typeparam>
    static class Permutation<T>
    {
        private static void Search(List<T[]> perms, Stack<T> stack, T[] a)
        {
            int N = a.Length;
            if (N == 0)
            {
                perms.Add(stack.Reverse().ToArray());
            }
            else
            {
                var b = new T[N - 1];
                Array.Copy(a, 1, b, 0, N - 1);
                for (int i = 0; i < a.Length; ++i)
                {
                    stack.Push(a[i]);
                    Search(perms, stack, b);
                    if (i < b.Length) { b[i] = a[i]; }
                    stack.Pop();
                }
            }
        }
        public static IEnumerable<T[]> All(IEnumerable<T> src)
        {
            var perms = new List<T[]>();
            Search(perms, new Stack<T>(), src.ToArray());
            return perms;
        }
    }
    
    /// <summary>
    /// 素因数分解
    /// </summary>
    static class PrimeFactors
    {
        public static IEnumerable<long> PrimeFactor(long n)
        {
            long i = 2;
            long tmp = n;

            while (i * i <= n) 
            {
                if (tmp % i == 0)
                {
                    tmp /= i;
                    yield return i;
                }
                else
                {
                    i++;
                }
            }
            if (tmp != 1) yield return tmp;//最後の素数も返す
        }

    }

}
