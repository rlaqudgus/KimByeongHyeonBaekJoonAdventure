using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Test
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int M = int.Parse(Console.ReadLine());

            List<int> list2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            Dictionary<int, int> myDict = new Dictionary<int, int>();

            StringBuilder sb = new StringBuilder();

            //Dictionary에 추가
            for (int i = 0; i < N; i++)
            {
                if (!myDict.ContainsKey(list[i]))
                {
                    myDict.Add(list[i], 1);
                }
                else myDict[list[i]]++;
            }

            for (int i = 0; i < M; i++)
            {
                if (!myDict.ContainsKey(list2[i]))
                {
                    sb.Append("0 ");
                }
                else sb.Append(myDict[list2[i]]+" ");
            }

            Console.WriteLine(sb);
        }
    }
}
