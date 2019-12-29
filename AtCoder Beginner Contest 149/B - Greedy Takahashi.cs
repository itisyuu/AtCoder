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
            var N = Inputer.LongArray1Line();
            var A = N[0];
            var B = N[1];
            var K = N[2];

            var amari = A - K;
            if(A + B < K)
            {
                A = 0;
                B = 0;
            }
            else
            {
                if (amari < 0)
                {
                    B = B + amari;
                    A = 0;

                }
                else
                {
                    A = A - K;
                }
            }
            

            Console.WriteLine("{0} {1}", A, B);
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
