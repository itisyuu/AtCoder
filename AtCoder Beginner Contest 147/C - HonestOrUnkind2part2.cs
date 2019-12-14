using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //入力部分,最初のN（人数）を読み取る
            var N = int.Parse(Console.ReadLine());
            var input_data = new List<List<int[]>>();

            //人数分の証言を読み取る
            for(int i = 0; i < N; i++)
            {
                var num_evidence = int.Parse(Console.ReadLine());
                var tmp = new List<int[]>();
                //特定の人の証言の数だけ読み取る
                for(int j= 0; j < num_evidence; j++)
                {
                    var evidence = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    tmp.Add(evidence);
                }
                input_data.Add(tmp);
            }

            var max = 0;//正直者の最大値
            
            //仮定のパターンだけ繰り返す、1をNビットシフトさせた数。つまり2のN乗
            for (int i = 0; i < 1<<N ; i++)
            {
                var flag = true;//今回の仮定はすべてあってるかどうかを確認する
                for (int j = 0; j < N; j++)
                {
                    //仮定のパターンに対して１ビットずつ確認していく
                    if ((i >> j & 1) == 0) { continue; }//不誠実な人のパターンは無視
                    else
                    {
                        for(int k = 0; k < input_data[j].Count(); k++)
                        {
                            var num = input_data[j][k][0]-1;
                            if (((i >> num) & 1) != input_data[j][k][1])//パターンが一致しなかった
                            {
                                flag = false;
                            }
                        }
                    }
                }
                if (flag)//今回の仮定が正しかったので正直者の数を数える
                {
                    var c=0;//立っているビットの数、つまり正直者の数
                    for(int n = 0; n < N; n++)
                    {
                        if(((i >> n) & 1) == 1) { c++; }//１つずつずらして「1」が立っているビットの数を調べる
                    }
                    max = max > c ? max : c;
                }
                
            }
            Console.WriteLine(max);

        }
    }
}
