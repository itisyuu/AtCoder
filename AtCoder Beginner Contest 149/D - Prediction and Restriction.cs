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
            var inp = Inputer.IntArray1Line();
            var N = inp[0];
            var K = inp[1];
            var inp2 = Inputer.IntArray1Line();
            var R = inp2[0];
            var S = inp2[1];
            var P = inp2[2];
            var T = Console.ReadLine().ToArray();

            var takahasi_num = new List<int>();
            var takahasi_te = new List<char>();

            var min_te_num = Math.Min(R, P);
            min_te_num = Math.Min(min_te_num, S);

            var max_te = Math.Max(S, Math.Max(R, P));
            var second = R + S + P -max_te-min_te_num;

            var min_te = 'r';
            if(min_te_num == R) { min_te = 'r'; }
            if (min_te_num == P) { min_te = 'p'; }
            if (min_te_num == S) { min_te = 's'; }

            var second_te = 'r';
            if(second == R) { second_te = 'r'; }
            if (second == P) { second_te = 'p'; }
            if (second == S) { second_te = 's'; }

            for (int i = 0; i < T.Length; i++)
            {
                
                if(T[i] == 'r')
                {
                    takahasi_num.Add(P);
                    takahasi_te.Add('p');
                }
                if (T[i] == 'p')
                {
                    takahasi_num.Add(S);
                    takahasi_te.Add('s');
                }
                if (T[i] == 's')
                {
                    takahasi_num.Add(R);
                    takahasi_te.Add('r');
                }
                if (i >= K &&( takahasi_te[i] == takahasi_te[i - K] ) && takahasi_te[i] == min_te)
                {
                    takahasi_num.RemoveAt(i);
                    takahasi_te.RemoveAt(i);
                    takahasi_num.Add(0);
                    if (i + K < N)
                    {
                        if (T[i+K] == 'r') { takahasi_te.Add('r'); }
                        if (T[i+K] == 'p') { takahasi_te.Add('p'); }
                        if (T[i+K] == 's') { takahasi_te.Add('s'); }

                    }
                    else
                    {
                        takahasi_te.Add(second_te);

                    }
                }
                if (i >= K &&( takahasi_te[i] == takahasi_te[i - K] ) && takahasi_te[i] != min_te)
                {
                    takahasi_num.RemoveAt(i);
                    takahasi_te.RemoveAt(i);
                    takahasi_num.Add(0);
                    if (i + K < N)
                    {
                        if (T[i+K] == 'r') { takahasi_te.Add('r'); }
                        if (T[i+K] == 'p') { takahasi_te.Add('p'); }
                        if (T[i+K] == 's') { takahasi_te.Add('s'); }

                    }
                    else
                    {
                        takahasi_te.Add(min_te);

                    }
                }


            }

            Console.WriteLine(takahasi_num.Sum());
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
