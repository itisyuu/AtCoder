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
            var N = int.Parse(Console.ReadLine());
            var Pos = new List<int[]>();
            for(int i = 0; i < N; i++)
            {
                var tmp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Pos.Add(tmp);
            }
            var enumrable = Enumerable.Range(0, N);
            var jyunretu = Permutation<int>.All(enumrable);
            var sum = 0d;
            foreach(int[] x in jyunretu)
            {
                for(int i = 0; i < x.Length - 1; i++)
                {
                    
                    sum+=Math.Sqrt(Math.Pow((Pos[x[i]][0] - Pos[x[i+1]][0]), 2) + Math.Pow((Pos[x[i]][1] - Pos[x[i+1]][1]), 2));
                }
            }
            Console.WriteLine(sum / jyunretu.Count());


        }
    }

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
}
